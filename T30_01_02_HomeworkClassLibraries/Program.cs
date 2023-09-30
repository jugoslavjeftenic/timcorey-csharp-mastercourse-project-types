using T30_01_02_HomeworkClassLibrariesLibrary;

namespace T30_01_02_HomeworkClassLibraries
{
    // Build a .NET Standard class library and Console application.
    // Put a couple calculation methods in it and call it from the Console.

    internal class Program
    {
        static void Main()
        {
            Calculator calculator = new();

            Console.WriteLine(calculator.Add(2,2));
            Console.WriteLine(calculator.Sub(2,2));
        }
    }
}