using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    public class Classes
    {
        public int Id;
        public string Name;
        public int Life_point;
        public int Strength;
        public int Agility;
        public int Intelligence;
        public int Initiative;
        public int Social;
        public DateTime CreatedAt;
        public DateTime UpdatedAt;

        public Classes(int id, string name, int life_point, int strength, int agility, int intelligence, int initiative, int social, DateTime ca, DateTime ua)
        {
            Id = id;
            Name = name;
            Life_point = life_point;
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
            Social = social;
            CreatedAt = ca;
            UpdatedAt = ua;
        }
    }
}
