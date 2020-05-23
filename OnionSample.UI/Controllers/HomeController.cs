using Microsoft.AspNetCore.Mvc;
using OnionSample.Application.Interfaces;
using OnionSample.UI.Models;
using OnionSample.UI.ViewModels;
using System.Diagnostics;
using System.Threading.Tasks;

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
        public async Task<IActionResult> AddToDoAsync(HomeViewModel model)
        {
            await _addToDoItemUseCase.AddToDoItemAsync(model.Time, model.Description);
            return RedirectToAction("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
