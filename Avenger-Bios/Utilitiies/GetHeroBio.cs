using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using AvengersBioLister.Models;
using System.Net.Http;
using System.Threading.Tasks;

namespace AvengersBioLister.Utilitiies
{
    public static class GetHeroBio
    {

        public static async Task PullBioAsync(int heroSelection)
        {

            var access_token = Environment.GetEnvironmentVariable("SuperHeroAPI_AccessToken");
            var baseUrl = "https://www.superheroapi.com/api.php/";
            var client = new HttpClient();
            int heroId = DoSwitch(heroSelection);
            var responseHero = client.GetAsync($"{baseUrl}{access_token}/{heroId}").Result;
            var responseBody = await responseHero.Content.ReadAsStringAsync();
            var heroBio = JsonConvert.DeserializeObject<Avenger>(responseBody);
            Console.WriteLine("");
            Console.WriteLine("##################################\n");
            Console.WriteLine($"Character Name: {heroBio.Name}\n");
            Console.WriteLine("Character Biography");
            Console.WriteLine($"Character Name: {heroBio.biography.FullName}");
            Console.WriteLine($"Character Alias: {heroBio.biography.Aliases[0]}");
            Console.WriteLine($"Character Place of Birth: {heroBio.biography.PlaceOfBirth}\n");
            Console.WriteLine("Character First Comic Book Apperance");
            Console.WriteLine($"{ heroBio.biography.FirstComicBookApperance}\n");
            Console.WriteLine("Character's Appearance");
            Console.WriteLine($"Gender: {heroBio.appearance.Gender}");
            Console.WriteLine($"Height: {heroBio.appearance.Height[0]}");
            Console.WriteLine($"Weight: {heroBio.appearance.Weight[0]}");
            Console.WriteLine($"Eye Color: {heroBio.appearance.EyeColor}\n");
            Console.WriteLine($"Group Affiliations: {heroBio.connections.GroupAffiliation}");
            Console.WriteLine("\n\n");
            Console.WriteLine("To return to the main menu type \"menu\" or hit any key and enter");

            string userChoice = Console.ReadLine();
            userChoice = userChoice.ToLower();
            if (userChoice == "menu")
            {
                MainMenu menu = new MainMenu();

                //Set up my menu options
                var options = menu.BuildMainMenu();
                menu.DisplayMainMenu(options);

                //Gets choice form user.
                var heroSelected = menu.GetMenuSelection(options);
                await GetHeroBio.PullBioAsync(heroSelected);
            }

            else
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

        private static int DoSwitch(int heroSelection)
        {
            switch (heroSelection)
            {
                case 1: return 30;
                case 2: return 106;
                case 3: return 107;
                case 4: return 149;
                case 5: return 251;
                case 6: return 313;
                case 7: return 332;
                case 8: return 346;
                case 9: return 579;
                case 10: return 620;
                case 11: return 659;
                case 12: return 697;
                default: return 0;
            }

        }


    }
}
