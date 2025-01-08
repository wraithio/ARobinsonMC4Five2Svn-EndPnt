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
    public class ReverseCharController : ControllerBase
    {
        private readonly ReverseCharServices _reverseCharServices;

        public ReverseCharController(ReverseCharServices reverseCharServices)
        {
            _reverseCharServices = reverseCharServices;
        }

        [HttpGet]
        [Route("goReverseChar/{userString}")]

        public string goReverseChar(string userString)
        {
            return _reverseCharServices.goReverseChar(userString);
        }
    }
}