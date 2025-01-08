namespace ARobinsonMC4Five2Svn_EndPnt.Services
{
    public class ReverseCharServices
    {
        public string goReverseChar(string userString)
        {
            string reverseResult = "";
            for (int i = userString.Length - 1; i >= 0; i--)
            {
                reverseResult += userString[i];
            }
            return $"You entered {userString}, reversed is {reverseResult}.";
        }
    }
}