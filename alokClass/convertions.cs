using System;
using System.Collections.Generic;
using System.Text;

namespace loop
{
    class convertions
    {
        static void Main(string[] args)
        {
            /*            Console.WriteLine("My Convertions");
                        // implicity conversion smaller size to bigger size
                        int i = 0;
                        double d1 = i;
                        Console.WriteLine(d1);
                        d1 = 12.99;
                        i = (int)d1; // casting to int
                        Console.WriteLine(i);
                        i = Convert.ToInt32(d1);
                        Console.WriteLine(i);
                        // convert to string
                        string s1 = d1.ToString();
                        Console.WriteLine(s1 + 2);
                        d1 = double.Parse(s1);
                        Console.WriteLine(d1);
                        // use tryparse when not sure about input
                        // it returns boolean true or false
                        bool b1 = int.TryParse(d1.ToString(), out i);
                        if (b1)
                        {
                            Console.WriteLine(i);
                        }
                        else
                        {
                            Console.WriteLine("Not a valid integer");
                        }*/
            // parallel Array



            string[] roomtypes = { "Single", "Double", "Luxury", "Penthouse" };
            double[] rates = { 45.50, 99.99, 165.25, 1095.50 };
            for (int j = 0; j < rates.Length; j++)
            {
                Console.WriteLine($"{j + 1}. {roomtypes[j]} {rates[j]:C} per night");
            }

            Console.WriteLine("Please select one option");
            int myroom = int.Parse (Console.ReadLine());
            Console.WriteLine(myroom);




            // 1. Single $45.50 per night
        }
    }
}
