using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database.APP_AUTH_Tables
{
    public class LOGIN_USERS
    {
        public int ID { get; set; }
        public string USERNAME { get; set; }
        public string PASSWORD { get; set; }
        public int ID_SALT { get; set; }
        public string IS_ADMIN { get; set; }
    }
}
