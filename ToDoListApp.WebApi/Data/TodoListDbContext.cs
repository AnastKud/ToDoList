// <copyright file="TodoListDbContext.cs" company="ToDoListApp">
// Copyright (c) ToDoListApp. All rights reserved.
// </copyright>

using Microsoft.EntityFrameworkCore;
using ToDoListApp.WebApi.Models;

namespace ToDoListApp.WebApi.Data;

/// <summary>
/// Represents the database context for the To-Do list application.
/// </summary>
public class TodoListDbContext : DbContext
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TodoListDbContext"/> class.
    /// </summary>
    /// <param name="options">The database context options.</param>
    public TodoListDbContext(DbContextOptions<TodoListDbContext> options)
        : base(options)
    {
    }

    /// <summary>
    /// Gets or sets the collection of to-do items.
    /// </summary>
    public DbSet<ToDoItem> ToDoItems { get; set; } = null!;

    /// <inheritdoc/>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        ArgumentNullException.ThrowIfNull(modelBuilder);

        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<ToDoItem>().HasData(
            new ToDoItem
            {
                Id = 1,
                Title = "Complete project setup",
                Description = "Configure the solution and projects",
                IsCompleted = true,
            },
            new ToDoItem
            {
                Id = 2,
                Title = "Implement Web API",
                Description = "Create CRUD endpoints for todo items",
                IsCompleted = false,
            },
            new ToDoItem
            {
                Id = 3,
                Title = "Write unit tests",
                Description = "Add tests for application functionality",
                IsCompleted = false,
            });
    }
}