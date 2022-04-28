using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    class Room_characters
    {
        public int RoomId;
        public int CharacterId;
        
        public Room_characters(int ri, int ci)
        {
            RoomId = ri;
            CharacterId = ci;
        }
    }
}
