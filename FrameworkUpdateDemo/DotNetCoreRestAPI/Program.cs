using DotNetCoreRestAPI.Models.Commons;
using DotNetCoreRestAPI.Models.Db;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using DotNetCoreRestAPI.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.Configure<AppConfiguration>(builder.Configuration.GetSection("AppConfiguraiton"));

builder.Services.AddDbContext<ApplicaitonDbContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddScoped<ICounterRepository, CounterRepository>();
builder.Services.AddScoped<ICourseRepository, CourseRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
