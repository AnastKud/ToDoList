// <copyright file="Program.cs" company="ToDoListApp">
// Copyright (c) ToDoListApp. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using ToDoListApp.WebApi.Data;

var builder = WebApplication.CreateBuilder(args);

// Get connection string from appsettings.json.
var connectionString = builder.Configuration.GetConnectionString("TodoListConnection")
    ?? throw new InvalidOperationException("Connection string not found.");

// Register the connection to SQL Server.
builder.Services.AddDbContext<TodoListDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddControllers();
builder.Services.AddOpenApi();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();