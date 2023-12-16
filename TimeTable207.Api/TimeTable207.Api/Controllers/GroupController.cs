using Microsoft.AspNetCore.Mvc;
using TimeTable207.Api.Models;
using TimeTable207.Context.Contracts;
using TimeTable207.Context.Contracts.Models;

namespace TimeTable207.Api.Controllers
{
    // CRUD
    [ApiController]
    [Route("[controller]")]
    public class GroupController : ControllerBase
    {
        private readonly ITimeTableContext context;

        public GroupController(ITimeTableContext context)
        {
            this.context = context;
        }

        // /group
        [HttpGet]
        public IActionResult GetAll()
        {
            var groups = context.Groups.ToList();
            return Ok(groups);
        }

        // /group/133a6a2c-974d-4c57-9cc4-f54d12025194
        [HttpGet("{id:guid}")]
        public IActionResult Get(Guid id)
        {
            var group = context.Groups.FirstOrDefault(x => x.Id == id);
            return Ok(group);
        }

        [HttpPost]
        public IActionResult Create(GroupRequestApiModel model)
        {
            var item = new Group
            {
                Id = Guid.NewGuid(),
                Name = model.Name,
                Description = model.Description,
                CreatedAt = DateTimeOffset.Now,
                CreatedBy = "Я",
                UpdatedAt = DateTimeOffset.Now,
                UpdatedBy = "Я",
            };

            context.Groups.Add(item);
            return Ok(item);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group = context.Groups.FirstOrDefault(x => x.Id == id);
            if (group != null)
            {
                context.Groups.Remove(group);
            }

            return Ok();
        }
    }
}
