using System;
using System.Collections.Generic;
using System.Text;

namespace AppParcial2.ViewModels
{
    public class MainViewModel
    {
        //shift+3+region
        #region ViewModels
        //prop3+tab+tab
        public CountryViewModel Countries { get; set; }
        #endregion
        //shift+3+tab+tab
        #region Constructor
        //ctor+tab+tab
        public MainViewModel()
        {
            this.Countries = new CountryViewModel();
        }

        #endregion
    }

}
