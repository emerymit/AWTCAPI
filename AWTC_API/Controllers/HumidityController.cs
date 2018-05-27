using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AWTC_API.Controllers
{
    [Produces("application/json")]
    [Route("api/Humidity")]
    public class HumidityController : Controller
    {

        static string _latestHumidityRead;

        // GET: api/Humidity
        [HttpGet]
        public string Get()
        {
            return _latestHumidityRead;
        }

        // GET: api/Humidity/5
        [HttpGet("{id}", Name = "GetHumidity")]
        public string Get(int id)
        {
            _latestHumidityRead = id.ToString();
            return "";
        }
        

    }
}
