using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace formjdrppe.entities
{
    class Typeitem_items
    {
        public int ItemId;
        public int TypeItemId;


        public Typeitem_items(int ii, int tyi)
        {
            ItemId = ii;
            TypeItemId = tyi;
        }
    }
}
