namespace T31_01_01_UnitTestLibrary
{
    public class DisplayMessages
    {
        public string Greetings(string firstName, int hourOfTheDay)
        {
            string retVal;

            if (hourOfTheDay < 5)
            {
                retVal = $"Go to bed {firstName}.";
            }
            else if (hourOfTheDay < 12)
            {
                retVal = $"Good morning {firstName}.";
            }
            else if (hourOfTheDay < 18)
            {
                retVal = $"Good afternoon {firstName}.";
            }
            else
            {
                retVal = $"Good evning {firstName}.";
            }

            return retVal;
        }
    }
}
