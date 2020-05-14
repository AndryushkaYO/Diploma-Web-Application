using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Contracts.Entities
{
    public class Subject : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TeacherSubject> TeacerSubjects { get; set; }
    }
}
