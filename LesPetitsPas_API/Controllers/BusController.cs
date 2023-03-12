using LesPetitsPas_DAL.Interfaces;
using LesPetitsPas_DAL.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LesPetitsPas_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusRepository _repo;

        public BusController(IBusRepository repo)
        {
            _repo = repo;
        }

        // GET: api/<BusController>
        [HttpGet]
        public IEnumerable<Bus> Get()
        {
            return _repo.Get();

        }

        // GET api/<BusController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<BusController>
        [HttpPost]
        public IActionResult Post([FromBody] Bus bus)
        {
            return Ok(_repo.Create(bus));
        }

        // PUT api/<BusController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] DateTime dateTime)
        {
            return ();
        }

        // DELETE api/<BusController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
