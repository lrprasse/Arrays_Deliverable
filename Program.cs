/************************************************************************
 *   Logan Prasse
 *   Class Project - Deliverable 3: Arrays
 * 
 *   Uploaded to GitHub 09/19/2019
 * 
 *   Program demonstrates an auto-generated array and outputs each array
 *   value in a new line.
 ************************************************************************/

using System;

namespace Arrays_Deliverable
{
    class Program
    {
        static void Main(string[] args)
        {
            //added try catch to ensure the program doesn't "crash"
            try
            {

                // automatically builds a new array
                int[] array = new int[25];
                int add_element = 1;
                for (int i = 0; i < 25; i++)
                {
                    array[i] = add_element;
                    add_element++;
                }

                //runs through and outputs the array values at its index
                for (int i = 0; i < 25; i++)
                {
                    Console.WriteLine("Element value = " + array[i] + ", index value = " + i);
                }
                
            }
            catch
            {
                Console.WriteLine("Oh no! Something went wrong. Please restart the program.");
            }
        }
    }
}
