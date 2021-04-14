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
    [Route("api/character")]
    [EnableCors("AllowAnyOrigin")]
    [Consumes(MediaTypeNames.Application.Json)]
    public class CharacterController : Controller
    {
        private readonly ILogicHandler _logicHandler;

        public CharacterController(ILogicHandler logicHandler)
        {
            _logicHandler = logicHandler;
        }

        [HttpGet("list")]
        public IActionResult GetAll()
        {
            return Ok(_logicHandler.GetAll());
        }

        [HttpGet("get/{id}")]
        public IActionResult Get(Guid id)
        {
            return Ok(_logicHandler.GetCharacter(id));
        }

        [HttpPost("create")]
        public IActionResult CreateCharacter([FromBody] Character character)
        {
            _logicHandler.CreateCharacter(character);

            return Ok();
        }

        [HttpPut("add/experience/{exp}/{id}")]
        public IActionResult AddExperience(decimal exp, Guid id)
        {
            return Ok(_logicHandler.AddExperience(exp, id));
        }

        [HttpDelete("remove/{id}")]
        public IActionResult Remove(Guid id)
        {
            _logicHandler.Remove(id);

            return Ok();
        }
    }
}
