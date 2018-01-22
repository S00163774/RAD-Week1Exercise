using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using Week1Exercise.Models;

namespace Week1Exercise.Data
{
    public class CoreContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public CoreContext()
            : base("CoreContext")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}