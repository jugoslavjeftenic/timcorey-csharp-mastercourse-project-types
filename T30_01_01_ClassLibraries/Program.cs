using T30_01_01_ClassLibraries_04_Library;

namespace T30_01_01_ClassLibraries
{
    internal class Program
    {
        static void Main()
        {
            Generators generators = new();
            PersonModel person = new()
            {
                Prefix = "Mr.",
                FirstName = "Tim",
                LastName = "Corey"
            };

            string message = generators.WelcomeMessage(person.Prefix, person.LastName);

            Console.WriteLine(message);
        }
    }
}