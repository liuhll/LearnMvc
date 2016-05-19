using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnMvc.Domain.Entities
{
    public class ActionColumn
    {

        public Guid ActionColumnId { get; set; }

        public Guid ActionId { get; set; }

        public string ActionColumnName { get; set; }

        public Action Action { get; set; }
    }
}
