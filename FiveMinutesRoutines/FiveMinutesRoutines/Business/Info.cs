using System;
using Newtonsoft.Json;
using System.Collections.Generic;
namespace FiveMinutesRoutines.Business
{
    public class Info
    {
       
        [JsonProperty("UniqueId")]
        public string ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
     


        
    }
}
