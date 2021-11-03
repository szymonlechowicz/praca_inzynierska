using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PlcFxUa
{
    public class MBase : DbContext
    {
        public virtual DbSet<Measurement> Measurements { get; set; }
        public virtual DbSet<Item> Items { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Measurement>()
                .HasRequired<Item>(m => m.monitoredItems)
                .WithMany(mi => mi.measurements)
                .HasForeignKey<int>(m => m.monitoredId)
                .WillCascadeOnDelete(true);
        }
        public MBase()
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
    }
}
