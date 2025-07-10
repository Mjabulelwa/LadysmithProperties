using LadysmithProperties.Model;
using LadysmithProperties.Data;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace LadysmithProperties.Data
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            AppDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<AppDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Tenants.Any())
            {
                context.Tenants.AddRange(
                    new Tenant { Initials = "C", TenantName = "Carson", TenantLastName = "Alexander", Email = "CarsonAlerxander01@gaamil.com" },
                    new Tenant { Initials = "M", TenantName = "Meredith", TenantLastName = "Alonso", Email = "MeredithAlonso@gmail.com" },
                    new Tenant { Initials = "A", TenantName = "Arturo", TenantLastName = "Anand", Email = "ArturoAnand33@gmail.com" },
                    new Tenant { Initials = "G", TenantName = "Gytis", TenantLastName = "Barzdukas", Email = "GytisBarzdukas@gmail.com" },
                    new Tenant { Initials = "Y", TenantName = "Yan", TenantLastName = "Li", Email = "YanLi@Yahoo.com" },
                    new Tenant { Initials = "P", TenantName = "Peggy", TenantLastName = "Justice", Email = "PeggyJustice5@gmail.com" },
                    new Tenant { Initials = "L", TenantName = "Laura", TenantLastName = "Norman", Email = "LauraNorman07@gmail.com" },
                    new Tenant { Initials = "N", TenantName = "Nino", TenantLastName = "Olivetto", Email = "NinoOlivetto@gmail.com" }

                    );
            }

            if (!context.Accommodations.Any())
            {
                context.Accommodations.AddRange(
                    new Accommodation { AccommodationId = 4010, AccommodationName = "Egerton Manor", AccommodationPrice = (decimal)2200000, AccommodationDescription = "", ImageUrls = "images/Egerton_Manor.jpg" },
                    new Accommodation { AccommodationId = 4041, AccommodationName = "Royal Hotel", AccommodationPrice = (decimal)8000000, AccommodationDescription = "", ImageUrls =  "images/Royal_Hotel.jpg"  },
                    new Accommodation { AccommodationId = 1045, AccommodationName = "Ndaba Guest Lodge", AccommodationPrice = (decimal)3100000, AccommodationDescription = "", ImageUrls = "images/NdabaGuest_Lodge.jpg" },
                    new Accommodation { AccommodationId = 3141, AccommodationName = "Mt View", AccommodationPrice = (decimal)4522000, AccommodationDescription = "", ImageUrls = "images/Mtview_Lodge.jpg" },
                    new Accommodation { AccommodationId = 2021, AccommodationName = "PlatRand Loge", AccommodationPrice = (decimal)7000000, AccommodationDescription = "", ImageUrls = "images/Platrand_Lodge.jpg"  },
                    new Accommodation { AccommodationId = 2042, AccommodationName = "Crown Hotal", AccommodationPrice = (decimal)9000000, AccommodationDescription = "", ImageUrls = "images/Crown_Hotel.jpg"}
                    );
            }

            if (!context.Rentings.Any())
            {
                context.Rentings.AddRange(
                    new Renting { Price = (decimal)2400, MoveInDate = DateTime.Parse("2024/06/26"), MoveOutDate = DateTime.Parse("2026/03/22") },
                    new Renting { Price = (decimal)4400, MoveInDate = DateTime.Parse("2022/06/26"), MoveOutDate = DateTime.Parse("2026/03/22") },
                    new Renting { Price = (decimal)2400, MoveInDate = DateTime.Parse("2024/06/26"), MoveOutDate = DateTime.Parse("2026/03/22") },
                    new Renting { Price = (decimal)3500, MoveInDate = DateTime.Parse("2024/06/26"), MoveOutDate = DateTime.Parse("2026/03/22") },
                    new Renting { Price = (decimal)2800, MoveInDate = DateTime.Parse("2024/06/26"), MoveOutDate = DateTime.Parse("2026/03/22") },
                    new Renting { Price = (decimal)1700, MoveInDate = DateTime.Parse("2024/06/26"), MoveOutDate = DateTime.Parse("2026/03/22") },
                    new Renting { Price = (decimal)1700, MoveInDate = DateTime.Parse("2024/06/26"), MoveOutDate = DateTime.Parse("2026/03/22") }
                    );
            }

            context.SaveChanges();
        }
    }
}
