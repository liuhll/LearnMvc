using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMvc.Domain.Entities
{
    public class GroupManager
    {
        public Guid Id { get; set; }

        public string GroupName { get; set; }

        public string GroupInfo { get; set; }

        public Guid CreateUserId { get; set; }

        public virtual User CreateUser { get; set; }

        public virtual ICollection<GroupManager> GroupManagers { get; set; }

    }
}
