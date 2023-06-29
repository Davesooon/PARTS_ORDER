using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Models
{
    public static class SharedDataStore
    {
        public static int Id { get; set; }
        public static string Wydawca { get; set; }
        public static string Nazwa { get; set; }
        public static int PartId { get; set; }
        public static int KluczProduktu { get; set; }
        public static double Koszt { get; set; }
        public static int Ilosc { get; set; }
    }
}
