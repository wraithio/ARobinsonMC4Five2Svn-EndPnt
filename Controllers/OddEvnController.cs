using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ARobinsonMC4Five2Svn_EndPnt.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC4Five2Svn_EndPnt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OddEvnController : ControllerBase
    {
        private readonly OddEvnServices _oddEvnServices;

        public OddEvnController(OddEvnServices oddEvnServices)
        {
            _oddEvnServices = oddEvnServices;
        }

        [HttpGet]
        [Route("goOddEvn/{Num}")]

        public string goOddEvn(int Num)
        {
            return _oddEvnServices.goOddEvn(Num);
        }
    }
}