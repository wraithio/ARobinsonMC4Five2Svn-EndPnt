using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ARobinsonMC4Five2Svn_EndPnt.Services
{
    public class ReverseNumServices
    {
        public string goReverseNum(string userInt)
        {
            int convertedNum;
            bool success = int.TryParse(userInt, out convertedNum);           
            if (convertedNum == 0)
            {
                return "The number 0 cannot be reversed.";
            }
            else
            {
                int reverseInt = 0;
                int temp = convertedNum;
                while (temp > 0)
                {
                    int remainder = temp % 10;
                    reverseInt = reverseInt * 10 + remainder;
                    temp /= 10;
                }
                return $"You entered {userInt}, reversed is {reverseInt}.";
            }
        }
    }
}