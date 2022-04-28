using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    class Rooms
    {
        public int Id;
        public string Name;
        public DateTime CreatedAt;
        public DateTime UpdatedAt;


        public Rooms(int id, string name, DateTime ca, DateTime ua)
        {
            Id = id;
            Name = name;
            CreatedAt = ca;
            UpdatedAt = ua;
        }
    }
}
