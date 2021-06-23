using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vjezbe14.Models
{
    public class Kupac
    {
        public int IDKupac { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}