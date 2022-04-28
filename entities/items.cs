using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    class Items
    {
        public int Id;
        public string Name;
        public string Description;
        public DateTime CreatedAt;
        public DateTime UpdatedAt;
        public int RarityItemId;


        public Items(int id, string name, string description, DateTime ca, DateTime ua)
        {
            Id = id;
            Name = name;
            Description = description;
            CreatedAt = ca;
            UpdatedAt = ua;
        }
    }
}
