using System;
using System.Linq;
using AnimalCrossing.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace AnimalCrossing.Models
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AnimalCrossingContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AnimalCrossingContext>>()))
            {

                // You add more code here to seed database.
                // See: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-mvc-app/working-with-sql?view=aspnetcore-3.0&tabs=visual-studio
                if (!context.Species.Any())
                {
                    var species = new Species[] {
                        new Species{Name="Curl", Description="American Curl"},
                        new Species{Name="Bengal", Description="Bengalise Cat"},
                        new Species{Name="Chartreux", Description="French Breed"},
                        new Species{Name="Himalayan", Description="Himalayan Cat Breed"},
                        new Species{Name="Persian", Description="Persian Cat Breed"},
                        new Species{Name="Siberian", Description="Siberian Cat Breed"}
                    };

                    context.Species.AddRange(species);
                    //foreach(var spec in species)
                    //{
                    //    context.Species.Add(spec);
                    //}

                    context.SaveChanges();
                }

                if (!context.Cats.Any())
                {
                    var speciesType = context.Species.ToList();

                    var cats = new Cat[]
                    {
                        new Cat{Name="Findus", BirthDate=new DateTime(2019, 9, 23), Description="Fat and lazy", Gender=Gender.Female, SpeciesId=speciesType[0].SpeciesId, ProfilePicture="https://upload.wikimedia.org/wikipedia/commons/thumb/1/17/American_curl_2.jpg/1200px-American_curl_2.jpg"},
                        new Cat{Name="Tigeren", BirthDate=new DateTime(2017, 12,25), Description="A Wild boy", Gender=Gender.Male, SpeciesId=speciesType[1].SpeciesId, ProfilePicture="https://fluffyplanet.com/wp-content/uploads/2019/07/shutterstock_582832921.jpg"},
                        new Cat{Name="Makronen", BirthDate=new DateTime(2017, 5,7), Description="Always loves a treat", Gender=Gender.Male, SpeciesId=speciesType[2].SpeciesId, ProfilePicture="https://www.madpaws.com.au/wp-content/uploads/2019/11/Chartreux.jpg"},
                        new Cat{Name="Lama", BirthDate=new DateTime(2012, 4,10), Description="Always relaxed", Gender=Gender.Male, SpeciesId=speciesType[3].SpeciesId, ProfilePicture="https://www.holidogtimes.com/wp-content/uploads/2018/02/Screen-Shot-2018-02-15-at-12.55.48-1-810x411.png"},
                        new Cat{Name="Darius", BirthDate=new DateTime(2015, 7,14), Description="Comes from a respectably dynasty", Gender=Gender.Male, SpeciesId=speciesType[4].SpeciesId, ProfilePicture="https://vetstreet.brightspotcdn.com/dims4/default/7cc218c/2147483647/thumbnail/645x380/quality/90/?url=https%3A%2F%2Fvetstreet-brightspot.s3.amazonaws.com%2Fa5%2F69%2Fe639b7ab40c2a290e3296de726d8%2FPersian-AP-PIFN6J-645sm3614.jpg"},
                        new Cat{Name="Sevasto", BirthDate=new DateTime(2018, 9,9), Description="Loves the winter", Gender=Gender.Female, SpeciesId=speciesType[5].SpeciesId, ProfilePicture="https://lh3.googleusercontent.com/MYu5kqr9f8JjBqMkIyzRLvD_PR_dQtFtbu1IAm6e_cwgKBFbY42Wg55cw36l07bah0r_"},
                        new Cat{Name="Sorte", BirthDate=new DateTime(2014, 12,17), Description="Loves the dark", Gender=Gender.Female, SpeciesId=speciesType[2].SpeciesId, ProfilePicture="https://www.dogalize.com/wp-content/uploads/2017/03/Chartreux-cat.jpg"},
                        new Cat{Name="Nougat", BirthDate=new DateTime(2017, 3,19), Description="Very Playful", Gender=Gender.Female, SpeciesId=speciesType[0].SpeciesId, ProfilePicture="https://i.pinimg.com/originals/fb/b7/0e/fbb70ee540d2f7e9f90739b4f0903fba.jpg"}
                    };
                    context.Cats.AddRange(cats);

                    
                    context.SaveChanges();
                }


            }


        }
    }
}
