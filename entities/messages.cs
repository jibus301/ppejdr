using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    class Messages
    {
        public int Id;
        public string Message;
        public DateTime CreatedAt;
        public DateTime UpdatedAt;
        public int CharacterId;
        public int RoomId;


        public Messages(int id, string message, string description, DateTime ca, DateTime ua, int ci, int ri)
        {
            Id = id;
            Message = message;
            CreatedAt = ca;
            UpdatedAt = ua;
            CharacterId = ci;
            RoomId = ri;
        }
    }
}
