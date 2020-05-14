using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Contracts.Entities
{
    public class Premium : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TeacherPremium> TeacherPremiums { get; set; }
    }
}
