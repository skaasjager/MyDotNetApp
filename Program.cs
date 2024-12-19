using System.Drawing;
using System;
using System.Runtime.CompilerServices;
using System.Xml;

namespace MyDotNetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Part 2 - Variables / Data Types
            // C# Data Types
            object o;
            string s;
            dynamic d;
            var v = "0";
            Nullable<int> n = null;
            Enum e;
            Array a;
            Tuple<int, string> t;
            ValueTuple<int, string> vt;
            // anonymous types ...

            // .NET Data Types
            Boolean b1;
            Byte b2;
            Char c1;
            DateTime dt;
            Decimal d1;
            Double d2;
            Guid g1;
            Int16 i16; // short
            Int32 i32; // int
            Int64 i64; // long
            SByte sb;
            Single s1; // float
            String s2;
            TimeSpan ts;
            UInt16 ui16; // ushort
            UInt32 ui32; // uint
            UInt64 ui64; // ulong


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
