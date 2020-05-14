using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Contracts.Entities
{
    public class Lesson : BaseEntity
    {
        public DateTime Date { get; set; }
        public int TeacherSubjectId { get; set; }
        public TeacherSubject TeacherSubject { get; set; }
        public int ClassroomId { get; set; }
        public ClassRoom Classroom { get; set; }
        public int MaterialId { get; set; }
        public Material Material { get; set; }
    }
}
