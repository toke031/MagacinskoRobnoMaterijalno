using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Data.Model
{
    public partial class MagacinskoRobnoMaterijalnoDbContext : DbContext
    {
        public MagacinskoRobnoMaterijalnoDbContext(string connectionString) : base(connectionString)
        {

        }
    }
}
