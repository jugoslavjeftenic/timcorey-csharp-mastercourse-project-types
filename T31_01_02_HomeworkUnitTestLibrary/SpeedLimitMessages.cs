namespace T31_01_02_HomeworkUnitTestLibrary
{
    public class SpeedLimitMessages
    {
        public static string SpeedLimit(int speedLimit)
        {
            string output = "";

            if (speedLimit <= 30)
            {
                output = "You are passing through the school zone.";
            }
            else if (speedLimit <= 50)
            {
                output = "You are passing through the city zone.";
            }
            else if (speedLimit <= 80)
            {
                output = "You are traveling outside of the city zone.";
            }
            else if (speedLimit <= 130)
            {
                output = "You are traveling on the highway.";
            }
            else
            {
                output = "Your speed exceeds the limit.";
            }

            return output;
        }
    }
}
