using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Contracts.Entities
{
    public class Reward : BaseEntity
    {
        public string Name { get; set; }
        public ICollection<TeacherReward> TeacherRewards { get; set; }
    }
}
