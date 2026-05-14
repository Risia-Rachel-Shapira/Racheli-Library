using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Librery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LiberyController : ControllerBase
    {
        // GET: api/<LiberyController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<LiberyController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<LiberyController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<LiberyController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<LiberyController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
