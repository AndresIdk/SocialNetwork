using FluentValidation;
using FluentValidation.AspNetCore;
using SocialMedia.Core.Interfaces;
using SocialMedia.Infrastructure.Filters;
using SocialMedia.Infrastructure.Repositories;
using SocialMedia.Infrastructure.Validators;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().ConfigureApiBehaviorOptions(opc => { opc.SuppressModelStateInvalidFilter = true; });
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Inyeccion de dependencias - Repositorio SQL SERVER
builder.Services.AddTransient<IPostRepository, PostRepository>();
// Automapeador cambio entre modelos - AutoMapper
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
builder.Services.AddMvc(opc =>
{
    opc.Filters.Add<ValidationFilter>();
});

// Middleware validador de modelos - FluentValidator
builder.Services.AddFluentValidationAutoValidation();
builder.Services.AddFluentValidationClientsideAdapters();
builder.Services.AddValidatorsFromAssemblyContaining<PostValidator>();

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
