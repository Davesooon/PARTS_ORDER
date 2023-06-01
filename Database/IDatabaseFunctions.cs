using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.Database
{
    interface IDatabaseFunctions
    {
        Task<IEnumerable<string>> GetManufacturers();
    }
}
