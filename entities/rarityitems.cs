using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    class Rarityitems
    {
        public int Id;
        public string Name;
        public DateTime CreatedAt;
        public DateTime UpdatedAt;


        public Rarityitems(int id, string name, DateTime ca, DateTime ua)
        {
            Id = id;
            Name = name;
            CreatedAt = ca;
            UpdatedAt = ua;
        }
    }
}
