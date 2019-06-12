using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Rotorua Thermal Holiday Park User Login Application v1
            //Kris Boyte 30016677
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("This app will add two matrices together.");

            //declare arrays 3x3 in size
            int[,] arrayA = new int[3, 3];
            int[,] arrayB = new int[3, 3];
            int[,] arrayC = new int[3, 3];
            //random class to generate random numbers
            Random rand = new Random();

            //populate arrays A and B with random numbers -10 to 10
            for (int row = 0; row < arrayA.GetLength(0); row++)//rows
            {
                for (int column = 0; column < arrayA.GetLength(1); column++)//columns
                {
                    arrayA[row, column] = rand.Next(-10, 10);//populate with random number
                }
            }
            for (int row = 0; row < arrayB.GetLength(0); row++)//rows
            {
                for (int column = 0; column < arrayB.GetLength(1); column++)//columns
                {
                    arrayB[row, column] = rand.Next(-10, 10);//populate with random number
                }
            }
                        
            Console.WriteLine("\narrayA:");
            DisplayArray(arrayA); //call method to display arrayA

            Console.WriteLine("\narrayB:");
            DisplayArray(arrayB); //call method to display arrayB

            arrayC = AddArrays(arrayA, arrayB); //call method to add the two arrays together

            Console.WriteLine("\narrayA + arrayB = arrayC\n");
            Console.WriteLine("arrayC:");
            DisplayArray(arrayC); //call method to display arrayC


            Console.ReadLine();
        }
        //this method displays the array
        public static void DisplayArray(int[,] aray)
        {
            Console.WriteLine("--------------------");

            for (int row = 0; row < aray.GetLength(0); row++) //rows
            {
                for(int column = 0; column < aray.GetLength(1); column++) //columns
                {
                    Console.Write(aray[row, column] + "\t"); //display values seperated by a tab
                }
                Console.Write("\n");
            }
            Console.WriteLine("--------------------");
        }
        //this method adds two 3x3 arrays together
        public static int[,] AddArrays(int[,] aray1, int[,] aray2)
        {
            int[,] result = new int[3, 3];
            
            for (int row = 0; row < 3; row++) //rows
            {
                for (int column = 0; column < 3; column++) //columns
                {
                    result[row, column] = aray1[row, column] + aray2[row, column]; //do math
                    
                }
            }
            return result;            
        }

    }
}
