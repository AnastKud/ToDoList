// <copyright file="ErrorViewModel.cs" company="ToDoListApp">
// Copyright (c) ToDoListApp. All rights reserved.
// </copyright>

namespace ToDoListApp.WebApp.Models;

public class ErrorViewModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
