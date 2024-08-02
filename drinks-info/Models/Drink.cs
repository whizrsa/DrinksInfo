using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace drinks_info.Models
{
    public class Drink
    {
        public string idDrink {get;set;}
        public string strDrink {get;set;}
    }
    
    public class Drinks
    {
        [JsonProperty("drinks")]
        public List<Drink> DrinksList {get; set;}

        
    }
}