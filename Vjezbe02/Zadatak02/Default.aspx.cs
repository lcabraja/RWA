using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Zadatak02.Models;

namespace Zadatak02
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadCountries();
                LoadCities();
            }
        }

        private void LoadCountries()
        {
            foreach (Country country in Repository.GetCountries())
            {
                dlCountry.Items.Add(new ListItem(country.Name, country.ID.ToString()));
            }
        }

        private void LoadCities()
        {
            dlCities.Items.Clear();

            int countryID = int.Parse(dlCountry.SelectedValue);
            foreach (City city in Repository.GetCities())
            {
                if (city.IDCountry == countryID)
                    dlCities.Items.Add(city.Name);
            }
        }

        protected void dlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadCities();
        }
    }
}