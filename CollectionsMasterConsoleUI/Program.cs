using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace CollectionsMasterConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO: Follow the steps provided in the comments under each region.
            //Make the console formatted to display each section well
            //Utlilize the method stubs at the bottom for the methods you must create

            #region Arrays
            // Create an integer Array of size 50
            var arr = new int[50];

            //Create a method to populate the number array with 50 random numbers that are between 0 and 50
            Populater(arr);
            //Print the first number of the array
            Console.WriteLine(arr[0]);
            //Print the last number of the array            
            Console.WriteLine(arr.Length-1);
            Console.WriteLine("All Numbers Original");
            //Use this method to print out your numbers from arrays or lists

            NumberPrinter(arr);
            Console.WriteLine("-------------------");

            //Reverse the contents of the array and then print the array out to the console.
            //Try for 2 different ways
            /*     Hint: Array._____(); Create a custom method     */

            
            Console.WriteLine("All Numbers Reversed:");

            Array.Reverse(arr);
           
            foreach(var el in arr)
            {
                Console.WriteLine(el);
            }
            Console.WriteLine("---------REVERSE CUSTOM------------");

            for (var i = arr.Length-1; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }

            Console.WriteLine("-------------------");

            //Create a method that will set numbers that are a multiple of 3 to zero then print to the console all numbers
            Console.WriteLine("Multiple of three = 0: ");
            foreach(var el in arr)
            {
                if(el % 3 == 0)
                {
                    Console.WriteLine("this is el at first" + el);
                    arr[el] = 0;
                }

                Console.WriteLine(el);
            }

            Console.WriteLine("-------------------");

            //Sort the array in order now
            /*      Hint: Array.____()      */
            Console.WriteLine("Sorted numbers:");

            Array.Sort(arr);
            
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n************End Arrays*************** \n");
            #endregion

            #region Lists
            Console.WriteLine("************Start Lists**************");

            /*   Set Up   */
            //Create an integer List

            var numList = new List<int>(50);


            //Print the capacity of the list to the console

            Console.WriteLine(numList.Capacity);

            //Populate the List with 50 random numbers between 0 and 50 you will need a method for this            

            Populater(numList);
            //Print the new capacity

            Console.WriteLine(numList.Capacity);

            Console.WriteLine("---------------------");

            //Create a method that prints if a user number is present in the list
            //Remember: What if the user types "abc" accident your app should handle that!
            Console.WriteLine("What number will you search for in the number list?");
            int input = Int32.Parse(Console.ReadLine());
            NumberChecker(numList, input);

            Console.WriteLine("-------------------");

            Console.WriteLine("All Numbers:");
            //Print all numbers in the list
            NumberPrinter(numList);
            Console.WriteLine("-------------------");

            //Create a method that will remove all odd numbers from the list then print results
            Console.WriteLine("Odds Only!!");
           // OddKiller(numList);
            Console.WriteLine("------------------");

            //Sort the list then print results
            Console.WriteLine("Sorted Odds!!");

            numList.Sort();

            foreach (var item in numList)
            {
                Console.WriteLine(item);
            }

          
            Console.WriteLine("------------------");

            //Convert the list to an array and store that into a variable

            var converted = numList.ToArray();
            Console.WriteLine(converted);

            //Clear the list
            numList.Clear();

            #endregion
        }

        private static void ThreeKiller(int[] numbers)
        {
            
        }

        private static void OddKiller(List<int> numberList)

        {

              numberList.RemoveAll(x => x % 2 != 0); 

        }

      

        private static void NumberChecker(List<int> numberList, int searchNumber)
        {
            if(numberList.Contains(searchNumber))
            {
                Console.WriteLine("Yes the the number is valid");
            }
            else
            {
                Console.WriteLine($"{searchNumber} was not valid. Please put in a valid number");
            }
           ;
            
        }

        private static void Populater(List<int> numberList)
        {
            int rng;

            for (var i = 0; i < 50; i++)
            {
                rng = new Random().Next(1, 50);
                numberList.Add(rng);
            }

        }

        private static void Populater(int[] numbers)
        {
            int rng;
            
            for (var i = 0; i < 50; i++)
            {
                rng = new Random().Next(1, 50);
                numbers[i] = rng;
            }
            
        }        

        private static void ReverseArray(int[] array)
        {
            
        }

        /// <summary>
        /// Generic print method will iterate over any collection that implements IEnumerable<T>
        /// </summary>
        /// <typeparam name="T"> Must conform to IEnumerable</typeparam>
        /// <param name="collection"></param>
        private static void NumberPrinter<T>(T collection) where T : IEnumerable<int>
        {
            //STAY OUT DO NOT MODIFY!!
            foreach (var item in collection)
            {
                Console.WriteLine(item);
            }
        }
    }
}
