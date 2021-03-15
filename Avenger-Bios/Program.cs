using AvengersBioLister.Utilitiies;
using System.Threading.Tasks;
using System;
using Newtonsoft.Json;
using System.Net.Http;
using System.IO;

namespace AvengersBioLister
{
    class Program
    {
        static async Task Main(string[] args)
        {
            MainMenu menu = new MainMenu();

            //Set up my menu options
            var options = menu.BuildMainMenu();

            menu.DisplayMainMenu(options);

            //Gets choice form user.
            var heroSelected = menu.GetMenuSelection(options);
            await GetHeroBio.PullBioAsync(heroSelected);


        }
    }
}
