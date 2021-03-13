using AvengersBioLister.Utilitiies;
using System.Threading.Tasks;
using System;
namespace AvengersBioLister
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu menu = new MainMenu();

            //Set up my menu options
            var options = menu.BuildMainMenu();

            menu.DisplayMainMenu(options);

            //Gets choice form user.
            var heroSelected = menu.GetMenuSelection(options);
            var test = GetHeroBio.PullBioAsync(heroSelected);


        }
    }
}
