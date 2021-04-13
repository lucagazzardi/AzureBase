using InnAndDragons.DataBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnAndDragons.DataBusiness.Mock
{
    public static class Characters
    {
        public static List<Character> charactersList { get; set; } = new List<Character>()
        {
            new Character()
            {
                id = Guid.NewGuid(),
                name = "Geralt",
                classe = Class.Guerriero,
                race = Race.Umano,
                level = 15,
                experience = 200.00M,
                owner = "Gazza"
            },
            new Character()
            {
                id = Guid.NewGuid(),
                name = "Yennefer",
                classe = Class.Mago,
                race = Race.Umano,
                level = 13,
                experience = 150.00M,
                owner = "Frank"
            }
        };
    }
}
