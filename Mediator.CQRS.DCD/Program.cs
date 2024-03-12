using Mediator.CQRS.Services;
using huzcodes.Extensions.Exceptions;
using Mediator.CQRS.Application;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddFluentValidation(typeof(Program));
builder.Services.AddApplicationRegistrations();
builder.Services.AddServicesRegistrations();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.AddExceptionHandlerExtension();

app.UseAuthorization();

app.MapControllers();

app.Run();
