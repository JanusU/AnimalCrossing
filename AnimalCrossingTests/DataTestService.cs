using System;
using System.Collections.Generic;
using AnimalCrossing.Models;

namespace AnimalCrossingTests
{
    public class DataTestService
    {
        public static List<Species> GetTestSpecies()
        {
            var sessions = new List<Species>();
            sessions.Add(new Species()
            {
                SpeciesId = 1,
                Name = "Maine coon"
            });
            sessions.Add(new Species()
            {
                SpeciesId = 2,
                Name = "Lynx"
            });
            return sessions;
        }

        public static List<Cat> GetTestCats() {
            var sessions = new List<Cat>();
            sessions.Add(new Cat() {
                Name="Nougat", BirthDate=new DateTime(2017, 3,19), Description="Very Playful", Gender=Gender.Female, SpeciesId=0, ProfilePicture="https://i.pinimg.com/originals/fb/b7/0e/fbb70ee540d2f7e9f90739b4f0903fba.jpg"
            });
            sessions.Add(new Cat() {
                Name = "Testcat"
            });
            return sessions;
        }

        public DataTestService()
        {
        }
    }
}
