using Entities.ForLife;
using ForLife.DAL.Concrete.EntityFramework.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Concrete.EntityFramework
{
    public class ForLifeDbContext : DbContext
    {
        public ForLifeDbContext() : base("Server =.; Database=ForLifeDB; uid=sa; pwd=123")
        {

        }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<BloodGroup> BloodGroups { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<DonationType> DonationTypes { get; set; }
        public DbSet<Donor> Donors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<SecurityQuestion> SecurityQuestions { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<PatientDonor> PatientDonors { get; set; }
        public DbSet<Setting> Settings { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Configurations.Add(new AdminMapping());
            modelBuilder.Configurations.Add(new BloodGroupMapping());
            modelBuilder.Configurations.Add(new CityMapping());
            modelBuilder.Configurations.Add(new CountryMapping());
            modelBuilder.Configurations.Add(new DonationTypeMapping());
            modelBuilder.Configurations.Add(new DonorMapping());
            modelBuilder.Configurations.Add(new MessageMapping());
            modelBuilder.Configurations.Add(new PatientDonorMapping());
            modelBuilder.Configurations.Add(new PatientMapping());
            modelBuilder.Configurations.Add(new SecurityQuestionMapping());
            modelBuilder.Configurations.Add(new SettingMapping());

            modelBuilder.Entity<DonationType>()
                .HasMany(a => a.Donors)
                .WithMany(a => a.DonationTypes)
                .Map(a =>
                {
                    a.MapLeftKey("DonationTypeID");
                    a.MapRightKey("DonorID");
                    a.ToTable("DonationTypeDonor");

                });

            modelBuilder.Entity<DonationType>()
                .HasMany(a => a.Patients)
                .WithMany(a => a.DonationTypes)
                .Map(a =>
                {
                    a.MapLeftKey("DonationTypeID");
                    a.MapRightKey("PatientID");
                    a.ToTable("DonationTypePatient");
                });
            


        }
    }
}
