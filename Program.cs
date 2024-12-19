using System.Runtime.CompilerServices;

namespace MyDotNetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = string.Empty;

            while (string.IsNullOrEmpty(name))
            {
                name = GetName();
            }

            ShowName(name);
        }

        private static void ShowName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new Exception("Name cannot be empty!");

            }

            Console.WriteLine($"Hello, welcome {name}!");
        }

        private static string GetName()
        {
            Console.Write("Type your name and press enter: ");

            string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("");
                Console.WriteLine("Name cannot be empty!");
                Console.WriteLine("");
                return string.Empty;
            }

            return name;
        }
    }
}
