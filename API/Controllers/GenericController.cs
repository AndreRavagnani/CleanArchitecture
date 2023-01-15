using Application.Interfaces;
using Domain.Primitive;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public abstract class GenericController<TService, TEntity> : Controller
        where TService : IGenericService<TEntity>
        where TEntity : BaseEntity
    {

        public TService Service;       

        public GenericController(TService service)
        {
            Service = service;           
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPost]
        public virtual async Task<IActionResult> Add(TEntity entity)
        {
            var data = await Service.AddAsync(entity);
            return Ok(data);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpDelete]
        public virtual async Task<IActionResult> Delete(TEntity entity)
        {
            var data = await Service.UpdateAsync(entity);
            return Ok(data);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpPut]
        public virtual async Task<IActionResult> Update(TEntity entity)
        {
            var data = await Service.UpdateAsync(entity);
            return Ok(data);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet]
        public virtual async Task<IActionResult> GetAll()
        {
            var data = await Service.GetAllAsync();
            return Ok(data);
        }

        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [HttpGet("{id}")]
        public virtual async Task<IActionResult> GetById(int id)
        {
            var data = await Service.GetByIdAsync(id);
            return Ok(data);
        }
    }
}
