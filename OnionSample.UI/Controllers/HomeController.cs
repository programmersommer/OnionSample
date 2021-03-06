﻿using Microsoft.AspNetCore.Mvc;
using OnionSample.Application.Interfaces;
using OnionSample.UI.Models;
using OnionSample.UI.ViewModels;
using System.Diagnostics;
using System.Linq;

namespace OnionSample.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IToDoItemUseCases _toDoItemUseCases;

        public HomeController(IToDoItemUseCases toDoItemUseCases)
        {
            _toDoItemUseCases = toDoItemUseCases;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public IActionResult AddToDo(HomeViewModel model)
        {
            var itemAdded = _toDoItemUseCases.AddToDoItem(model.Time, model.Description);
            if (itemAdded)
                TempData["Message"] = "ToDo item was added";
            else
                TempData["Message"] = "ToDo item was not added";

            return RedirectToAction("Index");
        }

        [ValidateAntiForgeryToken]
        public JsonResult GetEvents(double start, double end)
        {
            // start and and are currently not used, but this is not a real solution - that's just a demo :)

            var items = _toDoItemUseCases.GetToDoItems().ToList();

            var events = from item in items
                         select new
                         {
                             id = item.Id,
                             title = item.Description,
                             start = item.EventDateTime,
                             allDay = false
                         };

            return Json(events.ToArray());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
