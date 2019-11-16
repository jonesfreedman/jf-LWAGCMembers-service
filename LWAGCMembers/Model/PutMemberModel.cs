using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LWAGCMembers.Model
{
    public class PutMemberModel
    {
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("address")]
        public string Address { get; set; }
        [BsonElement("city")]
        public string City { get; set; }
        [BsonElement("contact")]
        public string Contact { get; set; }
    }
}
