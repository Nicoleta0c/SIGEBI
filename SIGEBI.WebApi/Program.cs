using Microsoft.EntityFrameworkCore;
using SIGEBI.Infrastructure.Persistence.Repositories;
using SIGEBI.Infrastructure.Persistence.Context;
using SIGEBI.Application.Services;
using SIGEBI.Infrastructure.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<SIGEBIContext>(options =>
    options.UseSqlite("Data Source=sigebi.db"));
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<BookService>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
