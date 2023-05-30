using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database
{
    public class DatabaseFunctions
    {
        internal Task<IEnumerable<string>> GetManufacturers()
        {
            using (var partsdb = new PARTS_ORDER_DB())
            {
                var result = partsdb.manufacturers
                    .AsNoTracking()
                    .Select(x => x.NAME)
                    .AsEnumerable();

                if (result == null) return Task.FromResult(Enumerable.Empty<string>());

                return Task.FromResult(result);
            }
        }
    }
}
