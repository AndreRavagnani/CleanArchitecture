using Application.Interfaces;
using Application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet(Name = "GetPersons")]
        public PersonViewModel Get()
        {
            return _personService.GetPersons();
        }
    }
}
