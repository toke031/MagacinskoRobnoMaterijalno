using Microsoft.EntityFrameworkCore;
using MagacinskoRobnoMaterijalno.Models.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace MagacinskoRobnoMaterijalno.Models.Contexts
{
   public class MainDBContext:DbContext
    {
        public MainDBContext(DbContextOptions<MainDBContext> options) : base(options) { }
        public DbSet<Article> Articles { get; set; }
        public DbSet<Client> Clients { get; set; }
    }
}
