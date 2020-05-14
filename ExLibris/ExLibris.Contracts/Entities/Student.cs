using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Contracts.Entities
{
    public class Student : Person
    {
        public int ClassroomId { get; set; }
        public ClassRoom Classroom { get; set; }
    }
}
