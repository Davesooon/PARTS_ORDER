using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database.Tables
{
    public class PARTS_SELLERS
    {
        public int ID { get; set; }
        public string MANUFACTURER { get; set; }
        public string PART_ID { get; set; }
        public string PART_NAME { get; set; }
        public double PART_COST { get; set; }
        public char AVAILABLE { get; set; }
        public DateTime TRANSPORT_TIME { get; set; }
        public int UPDATE_COUNT { get; set; }
    }
}
