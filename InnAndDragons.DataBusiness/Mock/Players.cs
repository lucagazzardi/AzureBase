using InnAndDragons.DataBusiness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnAndDragons.DataBusiness.Mock
{
    public static class Players
    {
        public static List<Player> playersList { get; set; } = new List<Player>()
        {
            new Player()
            {
                id = Guid.NewGuid(),
                name = "Gazza",
                email = "gazza@gmail.com"
            },
            new Player()
            {
                id = Guid.NewGuid(),
                name = "Frank",
                email = "frank@gmail.com"
            },
            new Player()
            {
                id = Guid.NewGuid(),
                name = "Belen",
                email = "belen@gmail.com"
            }
        };

    }
}
