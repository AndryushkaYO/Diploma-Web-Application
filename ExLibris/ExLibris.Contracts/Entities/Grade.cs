using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Contracts.Entities
{
    public class Grade : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TeacherGrade> TeacherGrades { get; set; }
    }
}
