using SampleService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SampleService.Helpers
{
    public class GetData : IGetData
    {
        public List<City> GetSampleCities()
        {
            List<City> cities = new List<City>();

            // read cities from SQL database using Entity...
            Cities dbCities = new Cities();

            cities = dbCities.AllCities.ToList<City>();

            return cities;
        }

        public List<Animal> GetSampleWildlife()
        {
            List<Animal> animals = new List<Animal>();

            // read animals from SQL database using Entity...
            Animals dbAnimals = new Animals();

            animals = dbAnimals.AllAnimals.ToList<Animal>();

            return animals;
        }
    }
}