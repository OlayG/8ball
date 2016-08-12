using Magic8Ball.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Magic8Ball.DAL
{
    public class Magic8BallContext : DbContext
    {
        public Magic8BallContext() : base("8Ball")
        {

        }

        public DbSet<answers8ball> answers8balls { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}