using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MarsRover.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace MarsRover.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InstructionsController : ControllerBase
    {
        // GET api/instructions
        [HttpGet]
        public ActionResult<string> Get(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                return BadRequest("Input parameter is not a valid string");

            string output = RoverHelper.StartInstructions(input);
            return Ok(output);
        }
    }
}
