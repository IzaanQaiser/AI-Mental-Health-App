// 1. added builder.Services.AddControllers() for organised API endpoints
// 2. Set up temporary in-memory database
// 3. Added swagger to automatically show API details
// 4. Use controllers to handle API requests

using Microsoft.EntityFrameworkCore;
using MoodAnalyzerAPI.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Register the in-memory database
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseInMemoryDatabase("MoodAnalyzerDB"));

// Add OpenAPI/Swagger support
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

// Map controllers endpoints (this will look for controllers in your project)
app.MapControllers();

app.Run();