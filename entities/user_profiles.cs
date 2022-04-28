using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    class user_profiles
    {
        public int CharacterId;
        public int ItemId;

        public user_profiles(int ci, int ii)
        {
            CharacterId = ci;
            ItemId = ii;
        }
    }
}
