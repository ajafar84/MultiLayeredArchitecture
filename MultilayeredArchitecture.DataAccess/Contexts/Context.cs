using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultilayeredArchitecture.DataAccess.Contexts
{
    public partial class Context : DbContext
    {
        public Context() : base("name=Context")
        {
            //Disable Initializer
            Database.SetInitializer<Context>(null);

            //Disable Lazy Loading
            Configuration.LazyLoadingEnabled = false;

            //Set Timeout to 3 minutes
            Database.CommandTimeout = 180;
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Disable Cascade Delete for All Tables Relation
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
        }

        #region DbSets
        //public virtual DbSet<Models.Employee> Employees { get; set; }
        //public virtual DbSet<Job> Jobs { get; set; }
        #endregion
    }
}
