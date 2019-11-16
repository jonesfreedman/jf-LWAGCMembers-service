using LWAGCMembers.DataAccessLayer.Interfaces;
using LWAGCMembers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using MongoDB.Bson;

namespace LWAGCMembers.DataAccessLayer
{
    public class GetMembers : IGetMembers
    {
        public List<MemberModel> getMembers()
        {
            DataBaseConnection dbConn = new DataBaseConnection();
            var member = dbConn.getCollection().Find(data => true).ToList();
            var members = new List<MemberModel>();
            member.ForEach(item => members.Add(item));
            return members;
        }
    }
}
