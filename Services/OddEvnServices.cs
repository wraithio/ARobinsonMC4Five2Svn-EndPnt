namespace ARobinsonMC4Five2Svn_EndPnt.Services
{
    public class OddEvnServices
    {
        public string goOddEvn(string Num)
        {
            int convertedNum;
            bool success = int.TryParse(Num, out convertedNum);

            if (convertedNum == 0)
            {
                return "0 is neither even not odd.";
            }
            else if (convertedNum % 2 == 0)
            {
                return $"The number {convertedNum} is even.";
            }
            else
            {
                return $"The number {convertedNum} is odd.";
            }
        }
    }
}