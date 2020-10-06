using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RunescapeCalculators.Models
{
    public class RunescapeSkillModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Maxlevel { get; set; }
        public bool IsEliteSkill { get; set; }
    }
}
