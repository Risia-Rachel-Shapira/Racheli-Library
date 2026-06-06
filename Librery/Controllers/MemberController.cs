using Librery.Interfaces;
using Librery.Models;
using Librery.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace Librery.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MemberController : ControllerBase 
    {      
        private readonly IMember _memberServices;

        public MemberController (IMember memberServices)
        {
            _memberServices = memberServices;
        }
        [HttpGet]
        public ActionResult<List<Member>>Get()
        {
            return _memberServices.Get();
        }

        [HttpGet("{id}")]
        public ActionResult<Member> GetById(string idMember)
        {
            return _memberServices.GetId(idMember);
        }

        [HttpGet("{name}")]
        public ActionResult<Member> GetByName(string nameMember)
        {
            return _memberServices.GetName(nameMember);
        }

        [HttpPost]
        public ActionResult Add(Member member) 
        {
            if (member == null)
                return NotFound();
            _memberServices.Add(member);
            return Created();
        }

        [HttpDelete]
        public ActionResult Delete(Member member)
        {
            if (member == null)
                return NotFound();
            _memberServices.Delete(member);
            return Created();
        }
    }
}
