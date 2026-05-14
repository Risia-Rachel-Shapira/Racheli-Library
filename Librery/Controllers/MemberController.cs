using Librery.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Librery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase
    {
        private static List<Member> members = new List<Member>();
        // GET: api/<MemberController>
        [HttpGet]
        public List<Member> Get()
        {
            return members;
        }

        // GET api/<MemberController>/5
        [HttpGet("{id}")]
        public string Get(string idMember)
        {
            return idMember;
        }

        // POST api/<MemberController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MemberController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MemberController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
