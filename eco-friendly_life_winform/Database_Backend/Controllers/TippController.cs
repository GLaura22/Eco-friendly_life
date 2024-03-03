using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eco_friendly_life_winform.Database_Backend.Connection;
using eco_friendly_life_winform.Database_Backend.Tables;

namespace eco_friendly_life_winform.Database_Backend.Controllers
{
    internal class TippController
    {
        internal List<Tables.Tipp> GetTipps()
        {
            using (var context = new AppDbContext())
            {
                var tipps = context.Tipps.ToList();
                return tipps;
            }
        }
    }
}
