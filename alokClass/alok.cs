using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    class myloops
    {

        static void Main(string[] args)
        {
            int count = 0;
            do
            {
                Console.WriteLine(count++);
            } while (count < 10);
            // try password three times
            /*            string password = string.Empty;
                        count = 0;
                        do
                        {
                            if (count == 3)
                            {
                                Console.WriteLine("Too many attempts");
                                break;
                            }
                            Console.WriteLine("Please enter your password");
                            password = Console.ReadLine();
                            count++;
                        } while (password != "password");
                        Console.WriteLine("Welcome to TAFE correct password");*/

            // third loop for loop
            // vamo
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            //outro
           /* string[] names = { "Rose", "George", "Ellie", "Mariana", "Pedro" };
            foreach(string name in names)
            {
                Console.WriteLine(name);
            }*/
            // challlenge - create arrray of cities Sydney, Brisbane, Melbourne, Darwin

            string[] cities = { "Sydney", "Brisbane", "Melbourne", "Darwin" };
            foreach(string city in cities)
            {
                Console.WriteLine(city);
            }

        }
    }
}
