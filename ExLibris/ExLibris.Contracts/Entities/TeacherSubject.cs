using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Contracts.Entities
{
    public class TeacherSubject : BaseEntity
    {
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public ICollection<Mark> Marks { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
