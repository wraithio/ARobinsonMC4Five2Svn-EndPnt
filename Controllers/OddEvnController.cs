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

        public string goOddEvn(string Num)
        {
        
            int convertedNum;
            bool success = int.TryParse(Num, out convertedNum);
            if (success)
            {
                return _oddEvnServices.goOddEvn(Num);
            }
            else
            {
                return "Numbers and special characters are not acceptable.";
            }
        }
    }
}