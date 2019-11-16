using LWAGCMembers.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LWAGCMembers.DataAccessLayer.Interfaces
{
    interface IPutMember
    {
        void putMember(string id, PutMemberModel value);
    }
}
