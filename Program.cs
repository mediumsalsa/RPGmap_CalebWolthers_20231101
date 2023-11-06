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

        static int printNum = 0;

    


        static void Main(string[] args)
        {


            currentRow = 0;
            currentCol = 0;

            DrawMapScale(3);

            currentRow = 0;
            currentCol = 0;

            DrawMap();

            Console.ReadKey();



        }


        static void DrawMapScale(int scale)
        {
            while (currentRow < 12)
            {
                for (int j = 0; j < scale; j++)
                {
                    while (currentCol < 30)
                    {
                        for (int k = 0; k < scale; k++)
                        {
                            Console.Write(map[currentRow, currentCol]);
                        }
                        currentCol++;
                    }
                    currentCol = 0;
                    Console.WriteLine();
                }
                currentRow++;
                currentCol = 0;
            }

        }



        static void DrawMap()
        {
            Console.WriteLine("+------------------------------+");

            while (currentCol < 30)
            {
                if (currentCol == 0)
                {
                    Console.Write("|");
                }
                Console.Write(map[currentRow, currentCol]);
                currentCol++;

                if (currentCol >= 30)
                {
                    currentRow++;
                    if (currentRow < 12)
                    {  
                        currentCol = 0;
                        Console.Write("|");
                        Console.WriteLine();
                    }
                    else 
                        { 
                            currentCol = 32;
                            Console.Write("|");
                        }
                }
            }
            Console.WriteLine();
            Console.WriteLine("+------------------------------+");
        }


 









        static char[,] map = new char[,] // dimensions defined by following data:
    {
        {'S','^','^','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`'},
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
        {'`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','`','E'},
    };

        // usage: map[y, x]

        // map legend:
        // ^ = mountain
        // ` = grass
        // ~ = water
        // * = trees

    }
}
