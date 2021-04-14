using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace InnAndDragons.DataBusiness.Models
{
    public enum Class
    {
        Guerriero = 1, 
        Mago = 2, 
        Ladro = 3
    }

    public enum Race
    {
        Umano = 1, 
        Elfo = 2, 
        Nano = 3
    }

    public class Player
    {
        public Guid id { get; set; }

        public string name { get; set; }

        public string email { get; set; }
    }

    public class Character
    {
        public Guid id { get; set; }

        public string name { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Class classe { get; set; }

        [System.Text.Json.Serialization.JsonConverter(typeof(System.Text.Json.Serialization.JsonStringEnumConverter))]
        public Race race { get; set; }

        public int level { get; set; }

        public decimal experience { get; set; }

        public string owner { get; set; }
    }
}
