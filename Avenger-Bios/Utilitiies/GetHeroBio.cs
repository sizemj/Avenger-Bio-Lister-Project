using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AvengersBioLister.Utilitiies
{
    public static class GetHeroBio
    {
        //Pulling from JSON for now
        //Ant-Man Only
        public static void PullBio(int heroSelection)
        {
            var bioJson = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(@"Data\AntMan.json"));
            Console.WriteLine(bioJson.ToString());
        }


    }
}
