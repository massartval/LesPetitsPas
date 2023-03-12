using Microsoft.AspNetCore.Mvc;
using LesPetitsPas_DAL.Models;
using LesPetitsPas_DAL.Interfaces;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LesPetitsPas_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonRepository _repo;

        public PersonController(IPersonRepository repo)
        {
            _repo = repo;
        }
        // GET api/<PersonController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Person? person = _repo.Get(id);
            if (person is not null)
                return Ok(person);
            else return BadRequest();
        }

        // POST api/<PersonController>
        [HttpPost]
        public IActionResult Post(Person person)
        {
            return Ok(_repo.Create(person));
        }
    }
}
