using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Vjezbe14.Models
{
    public class Repo
    {
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public static List<Kupac> GetKupci()
        {
            List<Kupac> list = new List<Kupac>();

            DataSet ds = SqlHelper.ExecuteDataset(cs, "DohvatiKupce");

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(new Kupac
                {
                    IDKupac = (int)row["IDKupac"],
                    Ime = row["Ime"].ToString(),
                    Prezime = row["Prezime"].ToString(),
                    Email = row["Email"].ToString()
                });
            }

            return list;
        }

        public static Kupac GetKupac(int idKupac)
        {
            DataSet ds = SqlHelper.ExecuteDataset(cs, "DohvatiKupce");
            DataRow row = ds.Tables[0].Rows[0];
            return new Kupac
            {
                IDKupac = (int)row["IDKupac"],
                Ime = row["Ime"].ToString(),
                Prezime = row["Prezime"].ToString(),
                Email = row["Email"].ToString()
            };
        }

        public static List<Racun> GetRacuniKupca(int kupacID)
        {
            List<Racun> list = new List<Racun>();

            DataSet ds = SqlHelper.ExecuteDataset(cs, "DohvatiRacuneKupca", kupacID);

            foreach (DataRow row in ds.Tables[0].Rows)
            {
                list.Add(new Racun
                {
                    IDRacun = (int)row["IDRacun"],
                    BrojRacuna = row["BrojRacuna"].ToString(),
                    DatumIzdavanja = DateTime.Parse(row["IDRacun"].ToString()),
                    Komentar = row["Komentar"] != DBNull.Value ? row["Komentar"].ToString() : "-",

                });
            }

            return list;
        }
    }
}