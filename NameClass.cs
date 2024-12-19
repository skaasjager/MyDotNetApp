using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDotNetApp
{
    public class NameClass
    {
        public string Name { get; set; }
        private string LastName { get; set; }

        public void GetLastname()
        {
            Console.Write("Your lastname: ");

            LastName = Console.ReadLine();

            if (string.IsNullOrEmpty(LastName))
            {
                Console.WriteLine("");
                Console.WriteLine("Lastname cannot be empty!");
                Console.WriteLine("");
            }
        }

        public void GetName()
        {
            Console.Write("Type your name and press enter: ");

            Name = Console.ReadLine();

            if (string.IsNullOrEmpty(Name))
            {
                Console.WriteLine("");
                Console.WriteLine("Name cannot be empty!");
                Console.WriteLine("");
            }
        }

        public void ShowName()
        {
            Console.WriteLine($"Hello, welcome {Name} {LastName}");
        }
    }
}
