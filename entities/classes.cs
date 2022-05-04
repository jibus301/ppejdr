using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    public class Classes
    {
        private int Id;
        private string Name;
        private int Life_point;
        private int Strength;
        private int Agility;
        private int Intelligence;
        private int Initiative;
        private int Social;
        private DateTime CreatedAt;
        private DateTime UpdatedAt;

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
