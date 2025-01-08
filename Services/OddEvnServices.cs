using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ARobinsonMC4Five2Svn_EndPnt.Services
{
    public class OddEvnServices
    {
        public string goOddEvn(int Num)
        {
            if(Num == 0)
            {
                return "0 is neither even not odd.";
            }
            else if(Num % 2 == 0)
            {
                return $"The number {Num} is even.";
            }
            else
            {
                 return $"The number {Num} is odd.";
            }
        }
    }
}