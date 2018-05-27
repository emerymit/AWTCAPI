using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AWTC_API.Controllers
{
    [Produces("application/json")]
    [Route("api/Low")]
    public class LowController : Controller
    {
        static string _low;

        // GET: api/Low
        [HttpGet]
        public string Get()
        {
            return _low;
        }

        // GET: api/Low/5
        [HttpGet("{l}", Name = "GetLow")]
        public string Get(string l)
        {
            _low = l;
            return "";
        }
    }
}
