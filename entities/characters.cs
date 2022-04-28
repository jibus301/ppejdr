using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    class Characters
    {
        public int Id;
        public string Name;
        public int Level;
        public string Biograpy;
        public int Melee_damage;
        public int Remote_damage;
        public int Defense;
        public char Image;
        public int Life_point;
        public int Strength;
        public int Agility;
        public int Intelligence;
        public int Initiative;
        public int Social;
        public bool Is_npc;
        public DateTime CreatedAt;
        public DateTime UpdatedAt;
        public int UserId;
        public int ClassId;
        public int RaceId;
        public int SessionId;

        public Characters(int id, string name, int lvl, string bio, int m_d, int r_d, int defense, char img, int life_point, int strength, int agility, int intelligence, int initiative, int social, bool is_npc, DateTime ca, DateTime ua, int ui, int ci, int ri, int si)
        {
            Id = id;
            Name = name;
            Level = lvl;
            Biograpy = bio;
            Melee_damage = m_d;
            Remote_damage = r_d;
            Defense = defense;
            Image = img;
            Life_point = life_point;
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
            Social = social;
            Is_npc = is_npc;
            CreatedAt = ca;
            UpdatedAt = ua;
            UserId = ui;
            ClassId = ci;
            RaceId = ri;
            SessionId = si;
        }
    }
}
