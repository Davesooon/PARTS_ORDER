using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database.APP_AUTH_Tables
{
    public class PASS_SALT
    {
        public int ID { get; set; }
        public int ID_SALT { get; set; }
        public string SALT { get; set; }
    }
}
