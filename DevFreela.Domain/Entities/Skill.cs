using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevFreela.Domain.Entities
{
    public class Skill : BaseEntity
    {
        public string Description { get; private set; }

        public Skill(string description)
        {
            Description = description;
            CreatedAt = DateTime.Now;
        }

        public DateTime CreatedAt { get; private set; }

    }
}
