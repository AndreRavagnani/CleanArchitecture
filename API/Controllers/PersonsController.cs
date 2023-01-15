using Application.Interfaces;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    public class PersonsController : GenericController<IPersonService, Person>
    {
        public PersonsController(IPersonService service) : base(service)
        {
        }

        [HttpGet("GetPersons")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> GetPersons()
        {
            var data = Service.GetPersons();
            if (data == null) return Ok();
            return Ok(data);
        }
    }
}
