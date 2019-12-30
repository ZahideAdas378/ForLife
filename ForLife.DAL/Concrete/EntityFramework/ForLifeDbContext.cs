using Entities.ForLife;
using ForLife.DAL.Concrete.EntityFramework.Mapping;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ForLife.DAL.Concrete.EntityFramework
{
    public class ForLifeDbContext : DbContext
    {
        public ForLifeDbContext() : base("ForLifeConnection")
        {
            Database.SetInitializer(new ForLifeInitializer());
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
        public DbSet<PatientProfileSettings> ProfileSettings { get; set; }
        public DbSet<DonorProfileSettings> DonorProfileSettings { get; set; }
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
            modelBuilder.Configurations.Add(new PatientProfileSettingsMapping());
            modelBuilder.Configurations.Add(new DonorProfileSettingsMapping());

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

            modelBuilder.Entity<Donor>()
                .HasOptional(a => a.DonorProfileSettings)
                .WithRequired(a => a.Donor);

            modelBuilder.Entity<Patient>()
             .HasOptional(a => a.PatientProfileSettings)
             .WithRequired(a => a.Patient);

        }
    }
}
