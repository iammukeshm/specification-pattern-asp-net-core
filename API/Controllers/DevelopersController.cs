using Core.Entities;
using Core.Interfaces;
using Core.Specification;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DevelopersController : ControllerBase
    {
        public readonly IGenericRepository<Developer> _repository;

        public DevelopersController(IGenericRepository<Developer> repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var developers = await _repository.GetAllAsync();
            return Ok(developers);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var developer = await _repository.GetByIdAsync(id);
            return Ok(developer);
        }

        [HttpGet("specify")]
        public async Task<IActionResult> Specify()
        {
            //var specification = new DeveloperWithAddressSpecification(3);
            var specification = new DeveloperByIncomeSpecification();
            var developers = _repository.FindWithSpecificationPattern(specification);
            return Ok(developers);
        }
    }
}