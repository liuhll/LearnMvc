using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMvc.Domain.Entities
{
    public class ActionGroup
    {
        public Guid Id { get; set; }

        public Guid ActionId { get; set; }

        public Guid GroupManagerId { get; set; }

        public Guid CreateUserId { get; set; }

        public DateTime CreateDateTime { get; set; }

        public virtual Action Action { get; set; }

        public virtual GroupManager GroupManager { get; set; }

        public virtual User CreateUser { get; set; }

    }
}
