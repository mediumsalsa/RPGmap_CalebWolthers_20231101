using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGmap_CalebWolthers_20231101
{
    internal class Program
    {


        static int currentRow = 0;
        static int currentCol = 0;

        static int width;
        static int height;



        static void Main(string[] args)
        {



            width = map.GetLength(1);
            height = map.GetLength(0);

            Console.WriteLine("Current map width: " + width);
            Console.WriteLine("Current map height: " + height);



            DisplayLegend();

            currentRow = 0;
            currentCol = 0;

            DisplayMap();

            currentRow = 0;
            currentCol = 0;

            DisplayMap(2);

            currentRow = 0;
            currentCol = 0;

            DisplayMap(3);

            currentRow = 0;
            currentCol = 0;

            DisplayMap(4);

            currentRow = 0;
            currentCol = 0;

            DisplayMap(5);  

            Console.ReadKey();



        }


        static void DisplayMap(int scale)
        {



            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("+");
            for (int i = 0; i < width * scale; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");
            while (currentRow < height)
            {
                for (int j = 0; j < scale; j++)
                {
                    while (currentCol < width)
                    {
                        if (currentCol == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.Write("|");
                        }
                        for (int k = 0; k < scale; k++)
                        {
                            if (map[currentRow, currentCol] == '~')
                            {
                                Console.ForegroundColor = ConsoleColor.Blue;
                            }
                            else if (map[currentRow, currentCol] == '*')
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                            }
                            else if (map[currentRow, currentCol] == '^')
                            {
                                Console.ForegroundColor = ConsoleColor.Gray;
                            }
                            else if (map[currentRow, currentCol] == '`')
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            }


                            Console.Write(map[currentRow, currentCol]);
                        }
                        currentCol++;
                    }
                    currentCol = 0;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("|");
                    Console.WriteLine();
                }
                currentRow++;
                currentCol = 0;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("+");
            for (int i = 0; i < width * scale; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");

            Console.ForegroundColor = ConsoleColor.White;
        }

        static void DisplayLegend()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("+--------------+");
            Console.WriteLine("| ^ = mountain |");
            Console.WriteLine("| ` = grass    |");
            Console.WriteLine("| ~ = water    |");
            Console.WriteLine("| * = trees    |");
            Console.WriteLine("+--------------+");
        }
        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees


        static void DisplayMap()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");

            while (currentCol < width)
            {
                if (currentCol == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("|");
                }
                if (map[currentRow, currentCol] == '~')
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (map[currentRow, currentCol] == '*')
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (map[currentRow, currentCol] == '^')
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                else if (map[currentRow, currentCol] == '`')
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }

                Console.Write(map[currentRow, currentCol]);
                currentCol++;

                if (currentCol >= width)
                {
                    currentRow++;
                    if (currentRow < height)
                    {  
                        currentCol = 0;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("|");
                        Console.WriteLine();
                    }
                    else 
                        { 
                            currentCol = width + 2;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("|");
                        }
                }

            }
            Console.WriteLine();
            Console.Write("+");
            for (int i = 0; i < width; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine("+");

            Console.ForegroundColor = ConsoleColor.White;
        }







        static char[,] map = new char[,] // dimensions defined by following data:
   {
        {'~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~'},
        {'~','~','`','`','`','`','`','~','~','~','~','~','~','~','*','*','`','~','~','~','~','~','~','~','~','`','`','~','~','~','~','~','~','~','~','~','~','~'},
        {'~','`','`','*','*','`','`','`','`','~','~','~','~','~','`','`','`','~','~','~','~','~','~','~','~','`','`','^','^','^','^','^','^','^','~','~','~','~'},
        {'~','`','`','*','`','`','`','`','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','*','*','`','`','~','~','`','`','^','^','^','~','~','~'},
        {'~','~','`','`','`','^','`','^','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','*','`','^','^','^','`','`','`','`','^','~','~','~'},
        {'~','~','~','~','~','^','^','^','~','~','~','~','~','`','`','`','`','`','`','~','~','~','~','~','~','~','~','~','~','~','^','`','`','`','^','~','~','~'},
        {'~','~','~','~','~','~','~','~','~','~','~','~','~','~','`','`','`','^','`','~','~','~','~','~','~','~','~','~','~','~','~','`','`','`','~','~','~','~'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~'},
        {'^','^','^','^','`','`','`','`','`','`','`','`','`','`','~','~','~','~','~','~','~','~','~','~','~','~','^','^','`','`','`','*','~','~','~','~','~','~'},
        {'`','^','^','^','`','`','`','`','`','`','`','*','*','`','~','~','~','~','~','~','~','~','*','*','`','`','`','`','`','`','`','*','*','~','~','~','~','~'},
        {'`','~','^','^','^','`','`','`','`','`','*','*','*','`','~','~','~','~','~','~','~','~','*','*','*','`','`','`','`','`','`','`','*','~','~','~','~','~'},
        {'~','~','^','^','^','`','`','`','`','`','`','`','`','`','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','`','`','`'},
        {'~','`','`','`','`','`','`','`','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','`','`','`','`','*','*'},
        {'`','`','`','`','*','*','`','`','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','`','`','`','`','*','*'},
        {'`','`','`','*','*','*','*','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','`','`','`','`','`','*','*','*'},
        {'`','`','`','`','*','*','*','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','~','`','`','`','`','*','*','*','*'},



   }; 









   /*     static char[,] map = new char[,] // dimensions defined by following data:
    {
        {'^','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'^','^','`','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`'},
        {'^','^','`','`','`','*','*','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','~','~','~','`','`','`','`','`'},
        {'^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','`','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`','`','`'},
        {'`','`','`','`','`','~','~','~','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','^','^','^','^','`','`','`'},
        {'`','`','`','`','`','`','`','~','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
    }; */

        // usage: map[y, x]

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees

    }
}
