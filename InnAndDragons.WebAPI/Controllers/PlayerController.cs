using InnAndDragons.DataBusiness.Business;
using InnAndDragons.DataBusiness.Mock;
using InnAndDragons.DataBusiness.Models;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace InnAndDragons.WebAPI.Controllers
{
    [Route("api/player")]
    [EnableCors("AllowAnyOrigin")]
    [Consumes(MediaTypeNames.Application.Json)]
    public class PlayerController : Controller
    {
        private readonly ILogicHandler _logicHandler;

        public PlayerController(ILogicHandler logicHandler)
        {
            _logicHandler = logicHandler;
        }

        [Route("list")]
        [HttpGet]
        public IActionResult GetéPlayers()
        {
            return Ok(_logicHandler.GetPlayers());            
        }

        [Route("create")]
        [HttpGet]
        public IActionResult CreatePlayer(Player player)
        {
            _logicHandler.CreatePlayer(player);

            return Ok();
        }
    }
}
