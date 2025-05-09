using Microsoft.AspNetCore.Mvc;
using UserApp.Services;
using UserApp.Services.Models;

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

    [HttpGet]
    public async Task<IActionResult> Get(int id)
    {
        return Ok(await _usersService.GetAsync(id));
    }

    [HttpPost]
    public async Task<IActionResult> Create(User user)
    {
        user.Id = 0;
        return Ok(await _usersService.CreateAsync(user));
    }

    [HttpPatch]
    public async Task<IActionResult> Update(User user)
    {
        await _usersService.UpdateAsync(user);
        return NoContent();
    }

    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        await _usersService.DeleteAsync(id);
        return NoContent();
    }
}
