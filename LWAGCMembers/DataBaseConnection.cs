using LWAGCMembers.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LWAGCMembers
{
    public class DataBaseConnection
    {
        public IMongoCollection<MemberModel> getCollection()
        {
            Constants constants = new Constants();
            IMongoClient client = new MongoClient(constants.CONNECTIONSTRING);
            IMongoDatabase database = client.GetDatabase(constants.DATABASE);
            var collection = database.GetCollection<MemberModel>(constants.COLLECTION);
            return collection;
        }
    }
}
