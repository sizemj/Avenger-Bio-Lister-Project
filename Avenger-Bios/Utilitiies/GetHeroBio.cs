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

            if (heroSelection == 1)
            {
                var responseAntMan = client.GetAsync($"{baseUrl}{access_token}/30").Result;
                var responseBody = await responseAntMan.Content.ReadAsStringAsync();
                //var antManBioSerilized = JsonConvert.SerializeObject(File.ReadAllText(responseBody).);
                var antManBio = JsonConvert.DeserializeObject<Avenger>(responseBody);
                Console.WriteLine("");
                Console.WriteLine("##################################\n");
                Console.WriteLine($"Character Name: {antManBio.Name}\n");
                Console.WriteLine("Character Biography\n");
                Console.WriteLine($"Character Name: {antManBio.biography.FullName}");
                Console.WriteLine($"Character Alias: {antManBio.biography.Aliases[1]}");
                Console.WriteLine($"Character Place of Birth: {antManBio.biography.PlaceOfBirth}\n");
                Console.WriteLine("Character First Comic Book Apperance");
                Console.WriteLine($"{ antManBio.biography.FirstComicBookApperance}\n");
                Console.WriteLine("Character's Appearance");
                Console.WriteLine($"Gender: {antManBio.appearance.Gender}");
                Console.WriteLine($"Height: {antManBio.appearance.Height}");
                Console.WriteLine($"Weight: {antManBio.appearance.Weight[0]}");
                Console.WriteLine($"Eye Color: {antManBio.appearance.EyeColor}\n");
                Console.WriteLine($"Group Affiliations: {antManBio.connections.GroupAffiliation} ");

            }

            else
            {
                var responseAntMan = client.GetAsync($"{baseUrl}{access_token}/30").Result;
                var responseBody = await responseAntMan.Content.ReadAsStringAsync();
                var antManBio = JsonConvert.DeserializeObject<Avenger>(File.ReadAllText(responseBody));
                Console.WriteLine(antManBio.Name);
            }


        }


    }
}
