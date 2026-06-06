using Librery.Interfaces;
using Librery.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Librery.Services
{
    public class MemberServices : IMember
    {
        private readonly DataContext _context;
        public MemberServices(DataContext context)
        {
            _context = context;
        }

        public List<Member> Get()
        {
            return _context.members;
        }
        public Member GetId(string idMember)
        {
            return _context.members.FirstOrDefault(f => f.idMember == idMember);
        }
        public Member GetName(string nameMember)
        {
            return _context.members.FirstOrDefault(f => f.nameMember == nameMember);
        }
        public void Add(Member member)
        {
            _context.members.Add(member);
        }
        public void Delete(Member member)
        {
            _context.members.Remove(member);
        }
    }
}
