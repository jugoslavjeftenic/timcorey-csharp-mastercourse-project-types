namespace T31_02_02_SolutionMiniProjectLibrary
{
    public class Calculations
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Substract(double x, double y)
        {
            return x - y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Divide(double x, double y)
        {
            double output = 0;

            if (y != 0)
            {
                output = x / y;
            }

            return output;
        }
    }
}
