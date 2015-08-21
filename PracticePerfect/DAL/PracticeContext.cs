using PracticePerfect.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PracticePerfect.DAL
{
    public class PracticeContext : DbContext
    {

        public PracticeContext()
            : base("PracticeContext")
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<PatientEmployer> PatientEmployers { get; set; }
        public DbSet<PatientRelation> PatientRelations { get; set; }
        public DbSet<Consultation> Consultations { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public System.Data.Entity.DbSet<PracticePerfect.Models.PatientNextOfKin> PatientNextOfKins { get; set; }
    }
}