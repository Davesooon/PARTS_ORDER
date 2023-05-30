using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database.Tables
{
    public class CHECK_PARTS
    {
        public int ID { get; set; }
        public string MANUFACTURER { get; set; }
        public string PART_ID { get; set; }
        public string PART_NAME { get; set; }
        public int QUANTITY { get; set; }
        public DateTime CREATE_DATE { get; set; }
        public DateTime UPDATE_DATE { get; set; }
        public int UPDATE_COUNT { get; set; }
    }
}
