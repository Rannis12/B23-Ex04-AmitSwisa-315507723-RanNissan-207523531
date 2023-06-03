using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class ExerciseFunctions
    {
        public static void ShowDate()
        {
            Console.WriteLine("The Date is " + DateTime.Now.ToString("d"));
        }

        public static void ShowTime()
        {
            Console.WriteLine("The Hour is: " + DateTime.Now.ToString("HH:mm:ss"));
        }

        public static void ShowVersion()
        {
            Console.WriteLine("Version: 23.2.4.9805");
        }

        public static void CountSpaces()
        {
            Console.WriteLine("Please enter your sentence:");
            string input = Console.ReadLine();

            int counter = 0;

            if (input != null)
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == ' ')
                    {
                        counter++;
                    }
                }

                Console.WriteLine("There are " + counter + " spaces in your sentence.");
            }
        }
    }
}
