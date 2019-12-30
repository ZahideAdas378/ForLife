using Entities.ForLife;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Concrete.EntityFramework
{
    class ForLifeInitializer:CreateDatabaseIfNotExists<ForLifeDbContext>
    {
        protected override void Seed(ForLifeDbContext context)
        {
            Admin admin = new Admin()
            {
                FirstName = "admin",
                LastName = "admin",
                UserName = "Admin",
                Email = "admin@gmail.com",
                Password = "123"
            };
            context.Admins.Add(admin);
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupName = "A+"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupName = "A-"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupName = "B+"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupName = "B-"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupName = "AB+"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupName = "AB-"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupName = "0+"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupName = "0-"
            });



            Country country = new Country();
            country.CountryName = "Türkiye";
            country.Cities.Add(new City()
            {
                CityName = "İstanbul"
            });          
            
            country.Cities.Add(new City()
            {
                CityName = "Ankara"
            });
            country.Cities.Add(new City()
            {
                CityName = "İzmir"
            });
            context.Countries.Add(country);
            country = new Country();
            country.CountryName = "Amerika";
            country.Cities.Add(new City()
            {
                CityName = "New York"
            });
            country.Cities.Add(new City()
            {
                CityName = "Washington"
            });
            country.Cities.Add(new City()
            {
                CityName = "Texas"
            });
            context.Countries.Add(country);
            country = new Country();
            country.CountryName = "Almanya";
            country.Cities.Add(new City()
            {
                CityName = "Berlin"
            });
            country.Cities.Add(new City()
            {
                CityName = "Hamburg"
            });
            country.Cities.Add(new City()
            {
                CityName = "Frankfurt"
            });
            context.Countries.Add(country);
            context.DonationTypes.Add(new DonationType() { 
            DonationTypeName="Böbrek"            
            });
            context.DonationTypes.Add(new DonationType()
            {
                DonationTypeName = "İlik"
            });
            context.DonationTypes.Add(new DonationType()
            {
                DonationTypeName = "Göz"
            });
            context.DonationTypes.Add(new DonationType()
            {
                DonationTypeName = "Karaciğer"
            });
            context.DonationTypes.Add(new DonationType()
            {
                DonationTypeName = "Beyin"
            });
            context.SecurityQuestions.Add(new SecurityQuestion()
            {
                Question = "En çok sevdiğiniz renk?"
            });
            context.SecurityQuestions.Add(new SecurityQuestion()
            {
                Question = "En sevdiğiniz yemek?"
            });

            context.SecurityQuestions.Add(new SecurityQuestion()
            {
                Question = "En sevdiğiniz arkadaşınız?"
            });
            context.SecurityQuestions.Add(new SecurityQuestion()
            {
                Question = "İlk evcil hayvanınız adı?"
            });
            context.SecurityQuestions.Add(new SecurityQuestion()
            {
                Question = "Çocukluk lakabınız nedir?"
            });
            context.SaveChanges();
                       
        }
    }
}
