using System;

namespace Semenar7_CSharp_Start
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Задача 47: Задайте двумерный массив размером m×n,
            заполненный случайными вещественными числами.
            m = 3, n = 4.
            0,5 7 -2 -0,2
            1 -3,3 8 -9,9
            8 7,8 -7,1 9
            *
            Задача 50: Напишите программу, которая на вход
            принимает позиции элемента в двумерном массиве, и
            возвращает значение этого элемента или же указание,
            что такого элемента нет.
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            17 -> такого числа в массиве нет
            *
            Задача 52: Задайте двумерный массив из целых чисел.
            Найдите среднее арифметическое элементов в каждом
            столбце.
            Например, задан массив:
            1 4 7 2
            5 9 2 3
            8 4 2 4
            Среднее арифметическое каждого
            столбца: 4,6; 5,6; 3,6; 3.
            */


            // Задача 47:


            Console.WriteLine("Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.");

            Console.WriteLine("Введите число М:");

            bool numberCheck = int.TryParse(Console.ReadLine(), out int task47_m);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task47_m);
            }

            // считано число элементов М

            Console.WriteLine("Введите число N:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task47_n);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task47_n);
            }

            // считано число элементов N

            
            double[,] arr = new double[task47_m, task47_n];
            Random rnd = new Random();

            for (int i = 0; i < task47_m; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < task47_n; j++)
                {
                    arr[i, j] = rnd.Next(-10000, 10000)/100.0;
                    Console.Write("{0,7}", arr[i,j]);
                }
            }

            Console.WriteLine("\n");



            // Задача 50:

            Console.WriteLine("Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и " +
            "возвращает значение этого элемента или же указание, что такого элемента нет.");

            Console.WriteLine("Введите размерность квадратного массива:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task50_m);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task50_m);
            }

            // считано число элементов размерность (m)

                int[,] arr50 = new int[task50_m, task50_m];

                for (int i = 0; i < task50_m; i++)
                {
                    Console.WriteLine("\n");
                    for (int j = 0; j < task50_m; j++)
                    {
                        arr50[i, j] = rnd.Next(-100, 100);
                        Console.Write("{0,4}", arr50[i, j]);
                    }
                }
                Console.WriteLine("\n");

            Console.WriteLine("Введите координату по высоте двумерного массива (начиная с 1)");

            numberCheck = int.TryParse(Console.ReadLine(), out int task50_M);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task50_M);
            }

            // считано число элементов размерность (М)

            Console.WriteLine("Введите координату по длине двумерного массива (начиная с 1)");

            numberCheck = int.TryParse(Console.ReadLine(), out int task50_N);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task50_N);
            }

            // считано число элементов размерность (N)

            if ((task50_M > task50_m) || (task50_N > task50_m))
                Console.WriteLine("такого числа в массиве нет.");
            else
                Console.Write("{0,4}", arr50[task50_M-1, task50_N-1]);

            Console.WriteLine("\n");


            // Задача 52:

            Console.WriteLine("Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.");

            Console.WriteLine("Введите длину массива:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task52_w);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task52_w);
            }

            // ввели длину массива

            Console.WriteLine("Введите высоту массива:");

            numberCheck = int.TryParse(Console.ReadLine(), out int task52_h);
            while (!numberCheck)
            {
                Console.WriteLine("Введено не число. Повторите ввод:");
                numberCheck = int.TryParse(Console.ReadLine(), out task52_h);
            }

            // ввели высоту массива


            int[,] arr52 = new int[task52_h, task52_w];
            double[] arr52_averCol = new double[task52_w];
            rnd = new Random();

            for (int i = 0; i < task52_h; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < task52_w; j++)
                {
                    arr52[i, j] = rnd.Next(-100, 100);
                    Console.Write("{0,4}", arr52[i, j]);

                    if(i + 1 == task52_h)
                    {
                        for (int g = 0; g < task52_h; g++)
                        {
                            if (g == 0) arr52_averCol[j] = 0;
                            arr52_averCol[j] += arr52[g, j];
                        }
                        arr52_averCol[j] /= (task52_h * 1.0);
                    }
                   
                }
                
            }

            Console.WriteLine("\n\n");

            Console.WriteLine("Среднее арифметическое каждого столбца: \n");

            for (int i = 0; i < task52_w; i++)
                Console.Write(arr52_averCol[i] + ", ");

            Console.WriteLine("\n");
        }
    }
}
