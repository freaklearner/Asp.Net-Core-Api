using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [ApiVersion("1.2")]
    [Produces("application/json")]
    [Route("api/v{version:ApiVersion}/movies")]
    [ApiController]
    public class MovieV2Controller : ControllerBase
    {
        static List<MovieV2> movies = new List<MovieV2>()
        {
            new MovieV2(){Name="Iron Man", Description="Techie create a suite of metal",Type="Action, Technology"},
            new MovieV2(){Name="Batman",Description="Rich Guy fight criminals", Type="Action, Drama"}
        };

        public IActionResult Get()
        {
            return StatusCode(StatusCodes.Status200OK, movies);
        }
    }
}