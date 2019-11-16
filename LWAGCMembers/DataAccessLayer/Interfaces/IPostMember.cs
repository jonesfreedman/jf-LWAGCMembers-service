using LWAGCMembers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LWAGCMembers.DataAccessLayer.Interfaces
{
    interface IPostMember
    {
        void postMember(MemberModel newMember);
    }
}
