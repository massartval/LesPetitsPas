using Microsoft.AspNetCore.Mvc;
using LesPetitsPas_DAL.Interfaces;
using LesPetitsPas_DAL.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LesPetitsPas_API.Controller
{
    [Route("api/[controller]")]
    [ApiController]

    public class ChildController : ControllerBase
    { 

    private readonly IChildRepository _repository;

    public ChildController(IChildRepository childRepository)
    {
        _repository = childRepository;
    }

        // GET: api/<ChildController>

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Child child = _repository.Get(id);
            if(child is not null)
                return Ok(child);
            else return BadRequest();
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ChildController>/5

        // POST api/<ChildController>
        [HttpPost]
        public IActionResult Post([FromBody] Child child)
        {
            return Ok(_repository.Create(child));
        }

        // PUT api/<ChildController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ChildController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
