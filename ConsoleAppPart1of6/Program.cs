using System;

namespace ConsoleAppPart1of6
{
//    CONSOLE APP PART ONE ASSIGNMENT
//   Create a console app that does/contains the following:
//A one-dimensional array of strings.
//Ask the user to input some text.
//A loop that iterates through each string in the array and adds the user's text input to the end of each string. This step will not output anything to the console, but will update each array element by appending the user's text.
//Then create a second loop that prints off each string in the array one at a time.
    class Program
    {
        static void Main()
        {//   Create a console app that does/contains the following:
         //A one-dimensional array of strings.
            string[] cities = { "Montgomery", "Juneau", "Phoenix" };
            //Ask the user to input some text.
            Console.WriteLine("Please input city:");
            
            cities[cities.Length - 1] = Console.ReadLine();

            //A loop that iterates through each string in the array and adds the user's text input to the end of each string.

            ////This step will not output anything to the console, but will update each array element by appending the user's text.


            //Then create a second loop that prints off each string in the array one at a time.
            foreach (string city in cities)
            {
                Console.WriteLine(city);
            }
            

        }
    }
}
