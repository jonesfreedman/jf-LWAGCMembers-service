using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LWAGCMembers.DataAccessLayer;
using LWAGCMembers.DataAccessLayer.Interfaces;
using LWAGCMembers.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LWAGCMembers.Controllers
{
    [Route("api/[controller]")]
    public class MembersController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public List<MemberModel> Get()
        {
            try
            {
                IGetMembers members = new GetMembers();
                return members.getMembers();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Encountered " + ex.Message);
                List<MemberModel> emptyModel = new List<MemberModel>();
                return emptyModel;
            }
        }

        // POST api/<controller>
        [HttpPost]
        public void Post([FromBody]MemberModel newMember)
        {
            try
            {
                IPostMember member = new PostMember();
                member.postMember(newMember);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Encountered " + ex.Message);
            }
        }

        // PUT api/<controller>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody]PutMemberModel value)
        {
            IPutMember member = new PutMember();
            member.putMember(id, value);
        }

        // GET api/<controller>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
