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
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                collection.Add(GetKupacFromDataRow(row));
            }
            return collection;
        }

        public static Kupac GetKupac(int IDKupac)
        {
            DataSet ds = SqlHelper.ExecuteDataset(cs, "DohvatiKupca", IDKupac);
            DataRow row = ds.Tables[0].Rows[0];

            return GetKupacFromDataRow(row);
            
        }

        public static List<Grad> GetGradovi()
        {
            List<Grad> collection = new List<Grad>();
            DataSet ds = SqlHelper.ExecuteDataset(cs, "DohvatiGradove");
            foreach (DataRow row in ds.Tables[0].Rows)
            {
                collection.Add(GetGradFromDataRow(row));
            }
            return collection;
        }

        public static int GetKupciCount()
        {
            return (int)SqlHelper.ExecuteScalar(cs, "DohvatiBrojKupaca");
        }

        private static Kupac GetKupacFromDataRow(DataRow row)
        {
            return new Kupac
            {
                IDKupac = (int)row["IDKupac"],
                Ime = row["ime"].ToString(),
                Prezime = row["prezime"].ToString(),
                Email = row["email"].ToString(),
                Telefon = row["telefon"].ToString(),
                Grad = GetGradFromDataRow(row)
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