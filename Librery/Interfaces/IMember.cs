using Librery.Models;
using Librery.Services;
using Microsoft.AspNetCore.Mvc;

namespace Librery.Interfaces
{
    public interface IMember 
    {
        List<Member> Get();
        Member GetId(string idMember);
        Member GetName(string nameMember);
        void Add(Member member);
        void Delete(Member member);
    }
}
