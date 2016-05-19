using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearnMvc.Domain.Enum;

namespace LearnMvc.Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string UserId { get; set; }

        public string Name { get; set; }

        public string PassWord { get; set; }

        public Sex Sex { get; set; }

        public DateTime BirthDay { get; set; }

        public Guid DeptId { get; set; }

        public Guid PostionId { get; set; }

        public string Phone { get; set; }

        public string TelPhone { get; set; }

        public string Email { get; set; }

        public string OfficePhone { get; set; }

        public ICollection<UserGroup> UserGroups { get; set; }

    }
}
