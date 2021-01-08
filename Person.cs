using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsoleApplication
{
    internal class Person
    {
        Address a1;
        string name;
        string bloodGroup;
        string[] languages;

        internal Person(string name, string bloodGroup, Address a1, string[] languages)
        {
            this.name = name;
            this.bloodGroup = bloodGroup;
            this.languages = languages;
            this.a1 = a1;
        }

        internal void Display()
        {
            Console.WriteLine("--Person Details--");
            Console.WriteLine("Name: "+this.name);
            Console.WriteLine("Blood Group: {0}", this.bloodGroup);
            for (int i = 0; i < languages.Length; i++)
            {
                char temp = languages[i][0];
                Console.Write(char.ToUpper(temp) + languages[i].Substring(1));
                if (i+1 == languages.Length)
                {

                }
                else
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine();
            a1.showAddress();
        }
    }
}
