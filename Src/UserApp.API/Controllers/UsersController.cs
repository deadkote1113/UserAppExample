using Microsoft.AspNetCore.Mvc;
using UserApp.API.DTO.Users;
using UserApp.Services;

namespace UserApp.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase
{
    private readonly UsersService _usersService;

    public UsersController(UsersService usersService)
    {
        _usersService = usersService;
    }

    [HttpPost]
    public async Task<ActionResult<int>> Create(UserCreateDTO user)
    {
        var newUserId = await _usersService.CreateAsync(user.ToEntity());
        return Ok(newUserId);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserDTO>> Read(int id)
    {
        var user = await _usersService.GetAsync(id);
        return Ok(user.ToDTO());
    }

    [HttpPut]
    public async Task<ActionResult> Update(UserDTO user)
    {
        await _usersService.UpdateAsync(user.ToEntity());
        return NoContent();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult> Delete(int id)
    {
        await _usersService.DeleteAsync(id);
        return NoContent();
    }
}
