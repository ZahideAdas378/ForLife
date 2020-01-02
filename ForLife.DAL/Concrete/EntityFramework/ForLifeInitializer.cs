using Entities.ForLife;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLife.DAL.Concrete.EntityFramework
{
    class ForLifeInitializer : CreateDatabaseIfNotExists<ForLifeDbContext>
    {
        protected override void Seed(ForLifeDbContext context)
        {
            Admin admin = new Admin()
            {
                AdminID = 1,
                FirstName = "admin",
                LastName = "admin",
                UserName = "Admin",
                Email = "admin@gmail.com",
                Password = "123"
            };
            context.Admins.Add(admin);
            context.SaveChanges();

            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupID = 1,
                BloodGroupName = "A+"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupID = 2,
                BloodGroupName = "A-"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupID = 3,
                BloodGroupName = "B+"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupID = 4,
                BloodGroupName = "B-"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupID = 5,
                BloodGroupName = "AB+"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupID = 6,
                BloodGroupName = "AB-"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupID = 7,
                BloodGroupName = "0+"
            });
            context.BloodGroups.Add(new BloodGroup()
            {
                BloodGroupID = 8,
                BloodGroupName = "0-"
            });
            context.SaveChanges();
            context.Countries.Add(new Country()
            {
                CountryName = "Türkiye",
                CountryID = 1,
                Cities = new List<City>() {
                    new City(){ CityID=1, CityName="İstanbul" },
                    new City(){ CityID=2, CityName="Ankara" },
                    new City(){ CityID=3, CityName="İzmir" }

            }
            });
            context.SaveChanges();
            context.Countries.Add(new Country()
            {
                CountryName = "Amerika",
                CountryID = 2,
                Cities = new List<City>() {
                    new City(){ CityID=4, CityName="New York" },
                    new City(){ CityID=5, CityName="Washington" },
                    new City(){ CityID=6, CityName="Texas" }

            }
            });
            context.SaveChanges();
            context.Countries.Add(new Country()
            {
                CountryName = "Almanya",
                CountryID = 3,
                Cities = new List<City>() {
                    new City(){ CityID=7, CityName="Berna" },
                    new City(){ CityID=8, CityName="Hamburg" },
                    new City(){ CityID=9, CityName="Frankfurt" }

            }
            });
            context.SaveChanges();

            context.DonationTypes.Add(new DonationType()
            {
                DonationTypeID = 1,
                DonationTypeName = "Böbrek"
            });
            context.DonationTypes.Add(new DonationType()
            {
                DonationTypeID = 2,
                DonationTypeName = "İlik"
            });
            context.DonationTypes.Add(new DonationType()
            {
                DonationTypeID = 3,
                DonationTypeName = "Göz"
            });
            context.DonationTypes.Add(new DonationType()
            {
                DonationTypeID = 4,
                DonationTypeName = "Karaciğer"
            });
            context.DonationTypes.Add(new DonationType()
            {
                DonationTypeID = 5,
                DonationTypeName = "Beyin"
            });
            context.SecurityQuestions.Add(new SecurityQuestion()
            {
                SecurityQuestionID = 1,
                Question = "En çok sevdiğiniz renk?"
            });
            context.SecurityQuestions.Add(new SecurityQuestion()
            {
                SecurityQuestionID = 2,
                Question = "En sevdiğiniz yemek?"
            });

            context.SecurityQuestions.Add(new SecurityQuestion()
            {
                SecurityQuestionID = 3,
                Question = "En sevdiğiniz arkadaşınız?"
            });
            context.SecurityQuestions.Add(new SecurityQuestion()
            {
                SecurityQuestionID = 4,
                Question = "İlk evcil hayvanınız adı?"
            });
            context.SecurityQuestions.Add(new SecurityQuestion()
            {
                SecurityQuestionID = 5,
                Question = "Çocukluk lakabınız nedir?"
            });

            context.SaveChanges();
            context.Donors.Add(new Donor()
            {
                DonorID = 1,
                CityID = 1,
                Address = "asdasdjlaksjdalskd",
                BirthDate = new DateTime(1994, 04, 12),
                BloodGroupID = 1,
                ContactChannel = "Akadaş aracılığı ile",
                CreateDate = DateTime.Now,
                DonationDate = DateTime.Now,
                DonationTypeID = 1,
                Email = "sonar@gmail.com",
                FirstName = "Ümit",
                LastName = "Sonar",
                Password = "123",           
                Phone = "054444444",
                Photo = @"‪C:\Users\ASUS\Desktop\group.png",
                SecurityQuestionID = 4,
                SecurityAnswer = "boncuk",
                Gender = "Erkek",
                IsActive = true,
                UserName = "sonaradam",
                IdentityNumber = "11111111111",


            });
            context.SaveChanges();
            context.Donors.Add(new Donor()
            {
                DonorID = 2,
                CityID = 2,
                Address = "asdasdjlaksjdalskd",
                BirthDate = new DateTime(1994, 04, 12),
                BloodGroupID = 1,
                ContactChannel = "Akadaş aracılığı ile",
                CreateDate = DateTime.Now,
                DonationDate = DateTime.Now,
                DonationTypeID = 1,
                Email = "cafercan@gmail.com",
                FirstName = "Mustafa",
                LastName = "Akçakaya",
                Password = "123",               
                Phone = "054444444",
                Photo = @"‪C:\Users\ASUS\Desktop\group.png",
                SecurityQuestionID = 4,
                SecurityAnswer = "cicikuş",
                Gender = "Erkek",
                IsActive = true,
                UserName = "cafercan",
                IdentityNumber = "11111111112",
            });
            context.SaveChanges();
            context.Donors.Add(new Donor()
            {
                DonorID = 3,
                CityID = 3,
                Address = "asdasdjlaksjdalskd",
                BirthDate = new DateTime(1994, 04, 12),
                BloodGroupID = 1,
                ContactChannel = "Akadaş aracılığı ile",
                CreateDate = DateTime.Now,
                DonationDate = DateTime.Now,
                DonationTypeID = 1,
                Email = "arslanemre@gmail.com",
                FirstName = "Emre",
                LastName = "Arslan",
                Password = "123",          
                Phone = "054444444",
                Photo = @"‪C:\Users\ASUS\Desktop\group.png",
                SecurityQuestionID = 4,
                SecurityAnswer = "asd",
                Gender = "Erkek",
                IsActive = true,
                UserName = "arslanemre",
                IdentityNumber = "11111111113",
            });
            context.SaveChanges();
            context.Patients.Add(new Patient()
            {
                PatientID = 1,
                CityID = 1,
                Address = "asdasdjlaksjdalskd",
                BirthDate = new DateTime(1994, 04, 12),
                BloodGroupID = 1,
                ContactChannel = "Akadaş aracılığı ile",
                CreateDate = DateTime.Now,
                DonationDate = DateTime.Now,
                DonationTypeID = 1,
                Email = "karademir@gmail.com",
                FirstName = "Fatih",
                LastName = "Karademir",
                Password = "123",                
                Phone = "054444444",
                Photo = @"‪C:\Users\ASUS\Desktop\group.png",
                SecurityQuestionID = 4,
                SecurityAnswer = "asd",
                Gender = "Erkek",
                IsActive = true,
                UserName = "karademir",
                IdentityNumber = "11111111114",
            });
            context.SaveChanges();
            context.Patients.Add(new Patient()
            {
                PatientID = 2,
                CityID = 2,
                Address = "asdasdjlaksjdalskd",
                BirthDate = new DateTime(1994, 04, 12),
                BloodGroupID = 1,
                ContactChannel = "Akadaş aracılığı ile",
                CreateDate = DateTime.Now,
                DonationDate = DateTime.Now,
                DonationTypeID = 1,
                Email = "ftas@gmail.com",
                FirstName = "Furkan",
                LastName = "Taş",
                Password = "123",                
                Phone = "054444444",
                Photo = @"‪C:\Users\ASUS\Desktop\group.png",
                SecurityQuestionID = 4,
                SecurityAnswer = "asd",
                Gender = "Erkek",
                IsActive = true,
                UserName = "frknts",
                IdentityNumber = "11111111115",
            });

            context.SaveChanges();
            context.PatientProfileSettings.Add(new PatientProfileSettings()
            {
                PatientID = 1,
                isDispayBloodGroup = true,
                isDisplayName = true,
                isDisplayCity = true,
                isDisplayCountry = true,
                isDisplayDonationType = true,
                isDisplayEmail = true,
                isDisplayGender = true,
                isDisplayGSM = true,
                isDisplayLastName = true
            });
            context.SaveChanges();
            context.PatientProfileSettings.Add(new PatientProfileSettings()
            {
                PatientID = 2,
                isDispayBloodGroup = true,
                isDisplayName = true,
                isDisplayCity = true,
                isDisplayCountry = true,
                isDisplayDonationType = true,
                isDisplayEmail = true,
                isDisplayGender = true,
                isDisplayGSM = true,
                isDisplayLastName = true
            });
            context.SaveChanges();
            context.DonorProfileSettings.Add(new DonorProfileSettings()
            {
                DonorID = 1,
                isDispayBloodGroup = true,
                isDisplayName = true,
                isDisplayCity = true,
                isDisplayCountry = true,
                isDisplayDonationType = true,
                isDisplayEmail = true,
                isDisplayGender = true,
                isDisplayGSM = true,
                isDisplayLastName = true
            });
            context.SaveChanges();
            context.DonorProfileSettings.Add(new DonorProfileSettings()
            {
                DonorID = 2,
                isDispayBloodGroup = true,
                isDisplayName = true,
                isDisplayCity = true,
                isDisplayCountry = true,
                isDisplayDonationType = true,
                isDisplayEmail = true,
                isDisplayGender = true,
                isDisplayGSM = true,
                isDisplayLastName = true
            });
            context.SaveChanges();
            context.Settings.Add(new Setting()
            {
                SettingID = 1,
                logo = @"‪C:\Users\ASUS\Desktop\logo2.png",
                Title = "asd",
                Fax = "asd",
                Phone = "55555",
                Address = "asd",
                Email = "asd",
                Facebook = "asd",
                Youtube = "asd",
                Instagram = "asd",
                GoogleMap = "asd",
                LegalWarning = "üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aynı zamanda pek değişmeden elektronik dizgiye de sıçramıştır. 1960'lardarı ile popüler olmuştur.",
                LawLink = "asd",
                DecreeLink = "asd",
                CircularLink = "asd",
                ReligionDecisionLink = "asd",
                About = "üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmamış, aymanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.d",
                Mission = "üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metirem Ipsum pasajları da içeren Letraset yapraklarının yayınlanması ile ve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.d",
                Vision = "aüzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmekle kalmzamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.d",
                HomeVideo = "asd",
                FirstAside = "üzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri standardı sahte metinler olarak kullanılmıştır. Beşyüz yıl boyunca varlığını sürdürmeklın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.sd",
                SecondAside = "aüzere bir yazı galerisini alarak karıştırdığı 1500'lerden beri endüstri stanve yakın zamanda Aldus PageMaker gibi Lorem Ipsum sürümleri içeren masaüstü yayıncılık yazılımları ile popüler olmuştur.sd",
                VideoDescription = "dasd"

            });
            context.SaveChanges();
            context.DonorProfileSettings.Add(new DonorProfileSettings()
            {
                DonorID = 3,
                isDispayBloodGroup = true,
                isDisplayName = true,
                isDisplayCity = true,
                isDisplayCountry = true,
                isDisplayDonationType = true,
                isDisplayEmail = true,
                isDisplayGender = true,
                isDisplayGSM = true,
                isDisplayLastName = true
            });

            context.SaveChanges();
            //TODO: olmazsa base yaz.

        }
    }
}
