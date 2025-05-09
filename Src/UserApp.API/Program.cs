using Microsoft.EntityFrameworkCore;
using UserApp.Services;

AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DefaultConnectionString");
builder.Services.AddDbContext<PostgresDbContext>((DbContextOptionsBuilder options) => options.UseNpgsql(connectionString));

builder.Services.AddScoped<UsersService>();


builder.Services.AddControllers();
var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();