using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagacinskoRobnoMaterijalno.Models
{
    public class MainDBContext :DbContext
    {
        public MainDBContext() { }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Document> Documents { get; set; }
        public DbSet<DocumentItem> DocumentItems { get; set; }
        public DbSet<Warehouse> Warehouses { get; set; }
        public bool SaveAllChanges()
        {
            int changes =  base.SaveChanges();
            if(changes == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
