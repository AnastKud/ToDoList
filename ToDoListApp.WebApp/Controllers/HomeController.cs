// <copyright file="HomeController.cs" company="ToDoListApp">
// Copyright (c) ToDoListApp. All rights reserved.
// </copyright>

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ToDoListApp.WebApp.Models;

namespace ToDoListApp.WebApp.Controllers;

/// <summary>
/// Handles the main pages of the application.
/// </summary>
public class HomeController : Controller
{
    /// <summary>
    /// Returns the main page of the application.
    /// </summary>
    /// <returns>The main page.</returns>
    public IActionResult Index()
    {
        return View();
    }

    /// <summary>
    /// Returns the privacy page of the application.
    /// </summary>
    /// <returns>The privacy page.</returns>
    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    /// <summary>
    /// Returns the error page of the application.
    /// </summary>
    /// <returns>The error page.</returns>
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
