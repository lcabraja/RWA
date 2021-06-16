using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Zadatak01.Models.CustomValidators;

namespace Zadatak01.Models
{
    public class Kupac
    {
        public int IDKupac { get; set; }
        [Required(ErrorMessage = "Ime je obvezno!")]
        [ImeValidator]
        public string Ime { get; set; }
        [Required(ErrorMessage = "Prezime je obvezno!")]
        public string Prezime { get; set; }
        [EmailAddress(ErrorMessage ="Elektronicka adresa nije ispravna!")]
        public string Email { get; set; }
        [Phone(ErrorMessage = "Broj telefona nije ispravan!")]
        public string Telefon { get; set; }
        public Grad Grad { get; set; }

        public override string ToString()
        {
            return $"{Ime} {Prezime}";
        }
    }
}