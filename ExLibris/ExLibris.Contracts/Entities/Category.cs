using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Contracts.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TeacherCategory> TeacherCategories { get; set; }
    }
}
