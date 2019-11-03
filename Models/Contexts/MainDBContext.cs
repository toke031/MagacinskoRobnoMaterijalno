using Microsoft.EntityFrameworkCore;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Models.Contexts
{
   public class MainDBContext:DbContext
    {
        public DbSet<Article> Articles { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
