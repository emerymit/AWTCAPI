using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AWTC_API.Controllers
{
    [Produces("application/json")]
    [Route("api/Tempature")]
    public class TempatureController : Controller
    {

        static string _latestTempRead;


        public TempatureController()
        {
            //_latestTempRead = "0";
            //_tempreadings = new List<TempatureReading>();
        }


        // GET: api/Tempature
        [HttpGet]
        public string Get()
        {
            return _latestTempRead;
        }

        // GET: api/Tempature/5
        [HttpGet("{id}", Name = "GetTempature")]
        public string Get(int id)
        {
            _latestTempRead = id.ToString();
            //_tempreadings.Add(new TempatureReading { Tempature = id.ToString(), DateTime = DateTime.Now.ToString() });
            return "";
        }
        

    }
}
