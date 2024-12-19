using MyDotNetApp;

/*
 * Part 3 - Six types of modifiers
 * 
 * Public               Can be accessed from anywhere. Not ideal if you don’t want to expose a method or property to other classes.
 * Private              Can only be used in its own class or struct.
 * Protected	        Can only be accessed from the same class and its derived classes.
 * Internal protected	Can be accessed from the same assembly and the derived class of the containing class from any other assembly.
 * Internal             Can only be accessed from within the same assembly.
 * Private protected    Can only be accessed within the same class, and its derived class within the same assembly.
 * 
 * Follow the Single Responsibility Principle (SRP):
 *  https://en.wikipedia.org/wiki/Single-responsibility_principle
 */

namespace MyDotNetApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDotNetApp.NameClass nameClass = new();

            while(string.IsNullOrEmpty(nameClass.Name))
            {
                nameClass.GetName();
            }

            nameClass.GetLastname();

            nameClass.ShowName();
        }

        private void Part2()
        {
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
        }
    }
}
