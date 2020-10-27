using System;

namespace Lab1CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int Min = 9999999, Max = -9999999, posi1 = 0, posi2 = 0, posj1 = 0, posj2 = 0;
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int[] tempmas1 = new int[y];
            int[] tempmas2 = new int[y];
            int[,] mas = new int[x, y];
            Console.WriteLine();
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    mas[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{mas[i,j]}    ");
                }
                Console.WriteLine("\n");
            }
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (mas[i,j] > Max)
                    {
                        Max = mas[i, j];
                        posi1 = i;
                        posj1 = j;
                    }
                    if (mas[i, j] < Min)
                    {
                        Min = mas[i, j];
                        posi2 = i;
                        posj2 = j;
                    }
                }
            }
            mas[posi1, posj1] = Min;
            mas[posi2, posj2] = Max;
            Console.WriteLine($"Max = {Max}, Min = {Min}");
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    Console.Write($"{mas[i, j]}    ");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
