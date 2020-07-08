using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class TestContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Case> Cases { get; set; }

        public DbSet<Drug> Drugs { get; set; }

        public DbSet<Diagnosis> Diagnosis { get; set; }

        public DbSet<DiagnosisDrugs> DiagnosisDrugs { get; set; }

        public DbSet<Visit> Visit { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<System.Data.Entity.ModelConfiguration.Conventions.PluralizingTableNameConvention>();
        }
    }
}
