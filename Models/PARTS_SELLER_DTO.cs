﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Models
{
    public class PARTS_SELLER_DTO
    {
        public int ID { get; set; }
        public string WYDAWCA { get; set; }
        public string NAZWA { get; set; }
        public int KLUCZ_PRODUKTU { get; set; }
        public int ID_CZĘŚCI { get; set; }
        public double KOSZT { get; set; }
        public char DOSTĘPNOŚĆ { get; set; }
        public int ILOŚĆ { get; set; }
    }
}
