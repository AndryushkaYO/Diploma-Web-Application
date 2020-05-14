using System;
using System.Collections.Generic;
using System.Text;

namespace ExLibris.Contracts.Entities
{
    public class Material : BaseEntity
    {
        public string MaterialPath { get; set; }
        public ICollection<Lesson> Lessons { get; set; }
    }
}
