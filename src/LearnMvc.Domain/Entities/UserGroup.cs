using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMvc.Domain.Entities
{
    public class UserGroup
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public Guid GroupId { get; set; }

        public Guid CreateUserId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public virtual User User { get; set; }

        public virtual GroupManager GroupManager { get; set; }

        public virtual User CreateUser { get; set; }



    }
}
