using AppParcial2.Models;
using AppParcial2.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppParcial2.ViewModels
{
    public class CountryViewModel:BaseViewModel
    {
        //Api Service
        //shift+3+tab+tab
        #region Services
        private ApiService apiservice;
        #endregion
        #region Attributes
        private string name;
        private string capital;
        private string alpha2code;
        #endregion
        #region Properties
        public string Name
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }
        public string Capital
        {
            get { return this.capital; }
            set { SetValue(ref this.capital, value); }
        }
        public string Alpha2Code
        {
            get { return this.alpha2code; }
            set { SetValue(ref this.alpha2code, value); }
        }
        #endregion
        //shift+region+tab+tab
        #region Constructor
            //ctor+tab+tab
        public CountryViewModel()
        {
            this.apiservice = new ApiService();
            this.LoadCountry(); //ctrol+.+enter
        }
        #endregion

        #region Methods

        private async void LoadCountry()
        {

            //Llamar Api
            var country = await this.apiservice.Get<Country>(
               "https://restcountries.eu/rest/v2/",
               "name/",
               "brazil"
                );
            this.Name = country[0].Name;
            this.Capital = country[0].Capital;
            this.Alpha2Code = country[0].Alpha2Code;
        }
        #endregion

    }
}
