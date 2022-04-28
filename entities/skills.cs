using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    class Skills
    {
        public int Id;
        public string Name;
        public int Stat;
        public DateTime CreatedAt;
        public DateTime UpdatedAt;


        public Skills(int id, string name, int stat, DateTime ca, DateTime ua)
        {
            Id = id;
            Name = name;
            Stat = stat;
            CreatedAt = ca;
            UpdatedAt = ua;
        }
    }
}
