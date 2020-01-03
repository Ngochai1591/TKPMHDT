using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Order_Manager.DTO
{
    class billDTO
    {
        public string billId;
        public int ordinalNumber;
        public string foodId;
        public string username;
        public int quantity;
        public int cost;
        public string tableId;
        public DateTime date;
        public string status;
    }
}
