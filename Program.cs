
using FluentValidation.AspNetCore;
using Infra.Data;
using PrimeiraAPI.Mappers;
using PrimeiraAPI.Services;
using PrimeiraAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddFluentValidation(config =>
{
    config.RegisterValidatorsFromAssemblies(new List<System.Reflection.Assembly> { typeof(Program).Assembly });
});

builder.Services.AddSqlServer<ApplicationDbContext>(builder.Configuration["ConnectionString:Database"]);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IEmployeesService, EmployeesService>();
builder.Services.AddAutoMapper(typeof(EmployeesMapper));

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
