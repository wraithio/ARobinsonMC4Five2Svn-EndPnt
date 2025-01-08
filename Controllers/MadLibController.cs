using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using ARobinsonMC4Five2Svn_EndPnt.Services;
using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC4Five2Svn_EndPnt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;


        public MadLibController(MadLibServices madLibServices)
        {
            _madLibServices = madLibServices;
        }

        [HttpGet]
        [Route("goMadLib/{firstWord}/{secondWord}/{thirdWord}/{fourthWord}/{fifthWord}/{sixthWord}/{seventhWord}/{eighthWord}/{ninthWord}/{tenthWord}")]

        public string goMadLib(string firstWord, string secondWord, int thirdWord, string fourthWord, string fifthWord, string sixthWord, string seventhWord, string eighthWord, string ninthWord, int tenthWord)
        {
            return _madLibServices.goMadLib(firstWord, secondWord, thirdWord, fourthWord, fifthWord, sixthWord, seventhWord, eighthWord, ninthWord, tenthWord);

        }
    }
}