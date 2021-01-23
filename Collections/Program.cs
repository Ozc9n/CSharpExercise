using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
                                   //Stack Heap
            string[] isimler = new string[] {"Hasan","Ali","Muhammed","Engin"};
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);
            // Strings is an immutable 

            isimler = new string[5];
            isimler[4] = "Hakim";
            Console.WriteLine(isimler[4]);
            Console.WriteLine(isimler[0]);


            List<string> isimler2 = new List<string>{"Mesut","Mustafa","Cenk","Enes"};
            //List<string> isimler2 = new List<string>();
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("Fatih");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);

        }
    }
}
