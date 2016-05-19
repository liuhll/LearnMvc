using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMvc.Domain.Entities
{
    public class Action
    {
        public Guid Id { get; set; }

        public string ActionName { get; set; }

        public virtual IList<ActionColumn> ActionColumn { get; set; }

    }
}
