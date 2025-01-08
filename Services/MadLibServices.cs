using Microsoft.Extensions.ObjectPool;

namespace ARobinsonMC4Five2Svn_EndPnt.Services
{
    public class MadLibServices
    {
        public string goMadLib(string color, string adjective, string place, string adjective2, string place2, string singular_food, string plural_food, string verb, string plural_noun, string adjective3)
        {
            string[] LibWords =
            {
                color,
                adjective,
                place,
                adjective2,
                place2,
                singular_food,
                plural_food,
                verb,
                plural_noun,
                adjective3
            };
            int isNum;
            for (int i = 0; i < LibWords.Length - 1; i++)
            {
                bool success = int.TryParse(LibWords[i], out isNum);
                if (success)
                {
                    return "One or more of your inputs are invalid.";
                }

            }
            return $"My birds are so cool! They are {color}, {adjective} animals which have wings. They like to fly around the {place} which makes some people scared of them. But my birds are {adjective2}, and they don't want to hurt people. I have pet birds that live in {place2}. I like to feed them one {singular_food} and some {plural_food}. They like to {verb}. I am their favorite person, but they also like {plural_noun}. I want to convince my parents to get me {adjective3} bats.";
        }
    }
}