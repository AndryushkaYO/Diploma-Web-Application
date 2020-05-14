using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Contracts.Entities
{
    public class Teacher : Person
    {
        public double Experience { get; set; }
        public ICollection<TeacherCategory> TeacherCategories { get; set; }
        public ICollection<TeacherGrade> TeacherGrades { get; set; }
        public ICollection<TeacherPremium> TeacherPremiums { get; set; }
        public ICollection<TeacherReward> TeacherRewards { get; set; }
        public ICollection<TeacherSubject> TeacherSubjects { get; set; }
    }
}
