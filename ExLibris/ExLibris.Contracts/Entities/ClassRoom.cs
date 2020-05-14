using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Contracts.Entities
{
    public class Classroom : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<Student> Students { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
