using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AvengersBioLister.Models
{
    public class Biography
    {

        [JsonProperty("full-name")]
        public string FullName { get; set; }
        [JsonProperty("alter-egos")]
        public string AlterEgos { get; set; }
        public IList<string> Aliases { get; set; }
        [JsonProperty("place-of-birth")]
        public string PlaceOfBirth { get; set; }

        [JsonProperty("first-appearance")]
        public string FirstComicBookApperance { get; set; }
        public string Publisher { get; set; }
        public string Alignment { get; set; }


    }
}
