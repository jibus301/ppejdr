using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    class Skill_characters
    {
        public int CharacterId;
        public int SkillId;


        public Skill_characters(int ci, int si)
        {
            CharacterId = ci;
            SkillId = si;
        }
    }
}
