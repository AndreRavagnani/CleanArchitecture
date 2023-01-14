using Application.Interfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace MVC.Controllers
{
    public class PersonsController : Controller
    {
        private IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        public async Task<IActionResult> Index()
        {
            var model = await _personService.GetAllAsync();
            return View(model);
        }
    }
}
