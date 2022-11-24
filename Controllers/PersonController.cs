using Microsoft.AspNetCore.Mvc;
using ProgramowanieObiektoweMVC.Models.Person;

namespace ProgramowanieObiektoweMVC.Controllers
{
    public class PersonController : Controller
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            var model = new PersonViewModel()
            {
                Persons = new PersonModel().GetPersons()
            };
            return View(model);
        }
    }
}
