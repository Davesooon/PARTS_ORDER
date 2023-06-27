using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database.APP_AUTH_Tables
{
    public class LOGIN_USERS
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        [MinLength(4)]
        public string LOGIN { get; set; }
        [Required]
        [MinLength(6)]
        public string HASŁO { get; set; }
        [Required]
        public string ADMIN { get; set; }
    }
}
