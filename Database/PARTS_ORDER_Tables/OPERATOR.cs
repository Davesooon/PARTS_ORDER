using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database.PARTS_ORDER_Tables
{
    public class OPERATOR
    {
        [Key]
        [Required]
        [StringLength(11)]
        public int PESEL { get; set; }
        [Required]
        [MinLength(3)]
        public string IMIĘ { get; set; }
        [Required]
        [MinLength(4)]
        public string NAZWISKO { get; set; }
        [Required]
        [MinLength(5)]
        public string STANOWISKO { get; set; }
    }
}
