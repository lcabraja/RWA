
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak02.Models
{
    public class Repository
    {
        public static List<Country> GetCountries()
        {
            List<Country> countries = new List<Country>
            {
                new Country(1, "Croatia"),
                new Country(1, "Spain"),
                new Country(1, "Bulgaria"),
                new Country(1, "Italy")
            };

            return countries;
        }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City>
            {
                new City(1, "Zagreb"),
                new City(1, "Rijeka"),
                new City(1, "Split"),
                new City(1, "Osijek"),
                new City(2, "Madrid"),
                new City(2, "Malaga"),
                new City(2, "Barcelona"),
                new City(3, "The capital"),
                new City(4, "Sicily"),
                new City(4, "Milano")
            };

            return cities;
        }
    }
}