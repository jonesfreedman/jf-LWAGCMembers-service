using LWAGCMembers.DataAccessLayer.Interfaces;
using LWAGCMembers.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LWAGCMembers.DataAccessLayer
{
    public class PutMember : IPutMember
    {
        public void putMember(string filter, PutMemberModel value)
        {
            Constants constants = new Constants();
            var members = new List<MemberModel>();
            IMongoClient client = new MongoClient(constants.CONNECTIONSTRING);
            IMongoDatabase database = client.GetDatabase(constants.DATABASE);
            var collection = database.GetCollection<PutMemberModel>(constants.COLLECTION);
            //var member = collection.Find(data => true).ToList();
            //var chk = member.Where(r => r.Name.Trim() == filter.Trim()).Select(r => r.Name);
            collection.ReplaceOne(r => "5d94fc12095b79184c27d3c0" == filter.Trim(), value);
        }
    }
}
