using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AWTC_API.Controllers
{
    [Produces("application/json")]
    [Route("api/Manual")]
    public class ManualController : Controller
    {
        static string _windowState;

        // GET: api/Manual
        [HttpGet]
        public string Get()
        {
            return _windowState;
        }

        // GET: api/Manual/5
        [HttpGet("{state}", Name = "GetState")]
        public string Get(string state)
        {
            _windowState = state;
            return "";
        }
        
    }
}
