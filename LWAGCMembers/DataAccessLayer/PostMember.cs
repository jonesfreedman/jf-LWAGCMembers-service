using LWAGCMembers.DataAccessLayer.Interfaces;
using LWAGCMembers.Model;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LWAGCMembers.DataAccessLayer
{
    public class PostMember : IPostMember
    {
        public void postMember(MemberModel newMember)
        {
            MemberModel _newMember = new MemberModel();
            _newMember = newMember;
            DataBaseConnection dbConn = new DataBaseConnection();
            dbConn.getCollection().InsertOne(_newMember);
        }
    }
}
