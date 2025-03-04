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
    public class ReverseNumController : ControllerBase
    {
        private readonly ReverseNumServices _reverseNumServices;

        public ReverseNumController(ReverseNumServices reverseNumServices)
        {
            _reverseNumServices = reverseNumServices;
        }

        [HttpGet]
        [Route ("goReverseNum/{userInt}")]

        public string goReverseNum(string userInt)
        {
              int convertedNum;
            bool success = int.TryParse(userInt, out convertedNum);
            if(success)
            {
            return _reverseNumServices.goReverseNum(userInt);
            }
            else
            {
            return "Numbers and special characters are not acceptable.";
            }
        }
    }
}