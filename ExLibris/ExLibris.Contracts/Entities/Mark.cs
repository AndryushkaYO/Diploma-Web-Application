using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace ExLibris.Contracts.Entities
{
    public class Mark : BaseEntity
    {
        [IntegerValidator(MinValue = 1, MaxValue = 100)]
        public int StudentMark { get; set; }
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int LessonId { get; set; }
        public Lesson Lesson { get; set; }
    }
}
