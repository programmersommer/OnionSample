using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using OnionSample.Application.Interfaces;
using OnionSample.UI.Models;
using OnionSample.UI.ViewModels;

namespace OnionSample.UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAddToDoItemUseCase _addToDoItemUseCase;

        public HomeController(IAddToDoItemUseCase addToDoItemUseCase)
        {
            _addToDoItemUseCase = addToDoItemUseCase;
        }

        public IActionResult Index()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        public IActionResult AddToDo(HomeViewModel model)
        {
            _addToDoItemUseCase.AddToDoItem(model.Time, model.Description);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
