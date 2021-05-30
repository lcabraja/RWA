using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak02.Models
{
    public class City
    {
        public int IDCountry { get; set; }
        public string Name { get; set; }
        public City()
        {
        }

        public City(int idCountry, string name)
        {
            IDCountry = idCountry;
            Name = name;
        }
    }
}