using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database.Tables
{
    public class PARTS_SELLER
    {
        [Key]
        [Required]
        public int ID { get; set; }
        [Required]
        public string WYDAWCA { get; set; }
        [ForeignKey(nameof(CHECK_PARTS))]
        [Required]
        public int ID_CZĘŚCI { get; set; }
        [Required]
        public double KOSZT { get; set; }
        [Required]
        public char DOSTĘPNOŚĆ { get; set; }
    }
}
