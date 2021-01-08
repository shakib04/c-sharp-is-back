using System;

namespace TestConsoleApplication
{
    struct Address
    {
        short homeNumber;
        short roadNumber;
        byte postalCode;

        internal Address(short homeNumber, short roadNumber, byte postalCode)
        {
            this.homeNumber = homeNumber;
            this.roadNumber = roadNumber;
            this.postalCode = postalCode;
        }

        internal void showAddress()
        {
            Console.WriteLine("Home Number: {0}", this.homeNumber);
            Console.WriteLine("Road Number: {0}", this.roadNumber);
            Console.WriteLine("Postal Code: {0}", this.postalCode);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Address a1 = new Address(10, 20, 123);
            string[] languages = { "bangla", "english", "german" };
            Person p1 = new Person("Shakib", "B+", a1, languages);
            p1.Display();
        }
    }
}
