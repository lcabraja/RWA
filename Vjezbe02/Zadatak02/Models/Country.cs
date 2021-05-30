using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak02.Models
{
    public class Country
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Country(int id, string name)
        {
            ID = id;
            Name = name;
        }
    }
}