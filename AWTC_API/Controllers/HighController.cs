using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AWTC_API.Controllers
{
    [Produces("application/json")]
    [Route("api/High")]
    public class HighController : Controller
    {
        static string _high;
        // GET: api/High
        [HttpGet]
        public string Get()
        {
            return _high;
        }

        // GET: api/High/5
        [HttpGet("{h}", Name = "GetHigh")]
        public string Get(string h)
        {
            _high = h;
            return "";
        }
    }
}
