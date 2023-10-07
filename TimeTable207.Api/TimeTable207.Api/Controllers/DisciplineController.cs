using Microsoft.AspNetCore.Mvc;
using TimeTable207.Api.Models.Responses;
using TimeTable207.Services.Contracts;

namespace TimeTable207.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DisciplineController : ControllerBase
    {
        private readonly IDisciplineService disciplineService;

        public DisciplineController(IDisciplineService disciplineService)
        {
            this.disciplineService = disciplineService;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll(CancellationToken cancellationToken)
        {
            var items = await disciplineService.GetAllAsync(cancellationToken);
            var result = items.Select(x => new DisciplineResponse { Id = x.Id, Name = x.Name, Description = x.Description, }).ToArray();
            return Ok(result);
        }

        [HttpGet("{id:guid}")]
        public async Task<ActionResult> GetById(Guid id, CancellationToken cancellationToken)
        {
            var item = await disciplineService.GetByIdAsync(id, cancellationToken);
            if (item == null)
            {
                return BadRequest("Запрашиваемый элемент не найден");
            }

            return Ok(new DisciplineResponse
            {
                Id = item.Id,
                Name = item.Name,
                Description = item.Description,
            });
        }
    }
}
