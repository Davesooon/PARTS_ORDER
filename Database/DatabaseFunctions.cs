using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using PARTS_ORDER.Database.Tables;
using PARTS_ORDER.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database
{
    public class DatabaseFunctions
    {
        public static List<string> GetManufacturers()
        {
            using (var partsContext = new DatabaseInitializer())
            {
                List<string> ret = new List<string>();
                var result = partsContext.checkParts.Select(x => new { x.WYDAWCA }).Distinct().ToList();

                foreach (var item in result) 
                {
                    ret.Add(item.WYDAWCA);
                }

                return ret;
            }
        }

        public static List<PARTS_SELLER_DTO> GetTable()
        {
            using (var partsContext = new DatabaseInitializer())
            {
                List<PARTS_SELLER_DTO> ret = new List<PARTS_SELLER_DTO>();
                var result = partsContext.partsInfoV.ToList();
                
                foreach (var part in result)
                {
                    ret.Add(new PARTS_SELLER_DTO {
                        WYDAWCA = part.WYDAWCA,
                        NAZWA = part.NAZWA,
                        KOSZT = part.KOSZT,
                        DOSTĘPNOŚĆ = part.DOSTĘPNOŚĆ,
                        ILOŚĆ = part.ILOŚĆ
                    });
                }

                return ret;
            }
        }

        public static void AddPart(CHECK_PARTS checker, PARTS_SELLER seller)
        {
            try
            {
                using (var partContext = new DatabaseInitializer())
                {
                    partContext.checkParts.Add(checker);
                    partContext.SaveChanges();

                    int partID = partContext.checkParts.Max(x => x.ID_CZĘŚCI);

                    seller.ID_CZĘŚCI = partID;
                    seller.DOSTĘPNOŚĆ = checker.ILOŚĆ > 0 ? 'Y' : 'N';

                    partContext.partsSellers.Add(seller);
                    partContext.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                Debug.Write(ex.ToString());
            }
        }
    }
}
