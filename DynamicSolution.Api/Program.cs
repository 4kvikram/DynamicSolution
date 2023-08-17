using DynamicSolution.Api.Controllers;
using DynamicSolution.Core.GenericRepository;
using DynamicSolution.Core.Interface;
using DynamicSolution.Core.Mapper;
using DynamicSolution.Core.Service;
using DynamicSolution.DataAccess;
using DynamicSolution.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddDbContext<AppDbContext>(
    x =>x.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))

);




// Other configurations...
//builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEntityDtoMapper<Employee, EmployeeDto>, EntityDtoMapper<Employee, EmployeeDto>>();


//builder.Services.AddTransient(typeof(GenericController<,>));






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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
