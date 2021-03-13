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
            var url = "https://www.superheroapi.com/api.php/";

            HttpClient client = new HttpClient();
            //Not working here??
            HttpResponseMessage response = await client.GetAsync($"{url}{access_token}/30");
            var responseBody = await response.Content.ReadAsStringAsync();
            var antManBio = JsonConvert.DeserializeObject<Avenger>(File.ReadAllText(responseBody));

            //switch (heroSelection)
            //{
            //    case 1:
            //        HttpResponseMessage response = await client.GetAsync($"{url}{access_token}/30");
            //        var responseBody = await response.Content.ReadAsStringAsync();
            //        var antManBio = JsonConvert.DeserializeObject<Avenger>(File.ReadAllText(responseBody));
            //        Console.WriteLine(antManBio);
            //        break;

            //    default:
            //        Console.WriteLine("Did not work!");
            //        break;
            //}
        }


    }
}
