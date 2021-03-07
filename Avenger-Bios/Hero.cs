using System;
using System.Collections.Generic;
using System.Text;

namespace AvengersBioLister
{
    public class Hero
    {

        public Bio Bio { get; set; }
        public string GetHeroBio()
        {
            //To do get from the api here and pass it along. 
            return "A hero was chosen";
        }

        public string ShowHeroBio()
        {
            return "Some Hero's Bio";
        }

    }
}
