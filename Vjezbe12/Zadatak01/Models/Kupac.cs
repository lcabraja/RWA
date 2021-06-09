using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Zadatak01.Models
{
    public class Kupac
    {
        public int IDKupac { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public Grad Grad { get; set; }
    }
}