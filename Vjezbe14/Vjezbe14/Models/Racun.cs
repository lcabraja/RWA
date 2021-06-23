using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vjezbe14.Models
{
    public class Racun
    {
        public int IDRacun { get; set; }
        public DateTime DatumIzdavanja { get; set; }
        public string BrojRacuna { get; set; }
        public string Komentar { get; set; }
    }
}