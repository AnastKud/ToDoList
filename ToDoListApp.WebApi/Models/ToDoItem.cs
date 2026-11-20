// <copyright file="ToDoItem.cs" company="ToDoListApp">
// Copyright (c) ToDoListApp. All rights reserved.
// </copyright>

namespace ToDoListApp.WebApi.Models;

/// <summary>
/// Represents a task in the To-Do list.
/// </summary>
public class ToDoItem
{
    /// <summary>
    /// Gets or sets the task identifier.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Gets or sets the task title.
    /// </summary>
    public string Title { get; set; } = string.Empty;

    /// <summary>
    /// Gets or sets the task description.
    /// </summary>
    public string? Description { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether the task is completed.
    /// </summary>
    public bool IsCompleted { get; set; }
}