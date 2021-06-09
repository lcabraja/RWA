using Microsoft.ApplicationBlocks.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;

namespace Zadatak01.Models
{
    public class Repo
    {
        private static string cs = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;

        public static List<Kupac> GetKupci()
        {
            List<Kupac> collection = new List<Kupac>();
            DataSet ds = SqlHelper.ExecuteDataset(cs, "DohvatiKupce");
            foreach (DataRow in ds.Tables[0].Rows)
            {

            }
        }

        public static Kupac GetKupac(int IDKupac)
        {
            return null;
        }

        public static List<Grad> GetGradovi()
        {
            return null;
        }

        public static int GetKupciCount()
        {
            return -1;
        }

        private static Kupac GetKupacFromDataRow(DataRow row)
        {
            return new Kupac
            {
                IDKupac = (int)row["IDKupac"],
                Ime = row["ime"].ToString(),
                Prezime = row["ime"].ToString(),
                Email = row["ime"].ToString(),
                Telefon = row["ime"].ToString(),
                Grad = null
            };
        }

        private static Grad GetGradFromDataRow(DataRow row)
        {
            return new Grad
            {
                IDGrad = (int)row["IDGrad"],
                Naziv = row["Naziv"].ToString(),
                DrzavaID = (int)row["DrzavaID"]
            };
        }
    }
}