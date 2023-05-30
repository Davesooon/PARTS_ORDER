using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database.Tables
{
    public class PARTS_HISTORY
    {
        public int ID { get; set; }
        public string PART_ID { get; set; }
        public string PART_NAME { get; set; }
        public string USERNAME { get; set; }
        public DateTime CREATE_DATE { get; set; }
    }
}
