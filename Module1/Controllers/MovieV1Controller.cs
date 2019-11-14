using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Module1.Models;

namespace Module1.Controllers
{
    [ApiVersion("1.0")]
    [Produces("application/json")]
    [Route("api/v{version:ApiVersion}/movies")]
    [ApiController]
    public class MovieV1Controller : ControllerBase
    {
        static List<MovieV1> movies = new List<MovieV1>()
        {
            new MovieV1(){Description = "About a Brave Girl", Name="Brave"},
            new MovieV1(){Description = "About a Boy", Name="Wanted"}
        };
        public IActionResult Get()
        {
            return StatusCode(StatusCodes.Status200OK, movies);
        }
    }
}