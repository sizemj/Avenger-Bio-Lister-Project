using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace AvengersBioLister.Models
{
    public class Connections
    {
        [JsonProperty("group-affiliation")]
        public string GroupAffiliation { get; set; }
    }
}
