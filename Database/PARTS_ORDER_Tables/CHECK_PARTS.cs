using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database.Tables
{
    public class CHECK_PARTS
    {
        [Key]
        [Required]
        public int ID_CZĘŚCI { get; set; }
        [Required]
        [MinLength(10)]
        public string NAZWA { get; set; }
        [Required]
        [MinLength(7)]
        public int KLUCZ_PRODUKTU { get; set; }
        [Required]
        [MinLength(5)]
        public string WYDAWCA { get; set; }
        [Required]
        public int ILOŚĆ { get; set; }
    }
}
