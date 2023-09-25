using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Security.Cryptography;

namespace _2laba
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введите размер массивов: ");
            int N = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("\nЗадание 1.(случайный набор значений массива):\n");

            int[] mass = new int[N];
            int middleIndex = N / 2;
            int value = 1;
            
            //int[] massTwo = new int[N];

            Random r = new Random();

          
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = r.Next(100);
            }

            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine("Изначальный массив: ");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            int[] shellSortedArray = new int[mass.Length];
            Array.Copy(mass, shellSortedArray, mass.Length);

            stopwatch.Start();
            shell(shellSortedArray);
            stopwatch.Stop();

            Console.WriteLine("\n\nМассив после сортировки Шелла:");
            for (int i = 0; i < shellSortedArray.Length; i++)
            {
                Console.Write($"{shellSortedArray[i]} ");
            }

            Console.WriteLine($"\n\nВремя вработы сортировки Шелла: {stopwatch.Elapsed.TotalMilliseconds}");

            line();


            Console.WriteLine("Изначальный массив: ");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            int[] qsSortedArray = new int[mass.Length];
            Array.Copy(mass, qsSortedArray, mass.Length);

            stopwatch.Start();

            qs(qsSortedArray, 0, mass.Length - 1);
            stopwatch.Stop();

            Console.WriteLine("\n\nМассив после быстрой сортировки:");
            for (int i = 0; i < qsSortedArray.Length; i++)
            {
                Console.Write($"{qsSortedArray[i]} ");
            }

            Console.WriteLine($"\n\nВремя работы быстрой сортировки: {stopwatch.Elapsed.TotalMilliseconds}");

            line();

            Console.WriteLine("Изначальный массив:");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            int[] standartSortedArray = new int[mass.Length];
            Array.Copy(mass, standartSortedArray, mass.Length);

            stopwatch.Start();
            Array.Sort(standartSortedArray);
            stopwatch.Stop();

            Console.WriteLine("\n\nМассив после стандартной сортировки:");
            for (int i = 0; i < standartSortedArray.Length; i++)
            {
                Console.Write($"{standartSortedArray[i]} ");
            }

            Console.WriteLine($"\n\nВремя работы стандартной сортировки: {stopwatch.Elapsed.TotalMilliseconds}");

            line();
            stop();

            Console.WriteLine("Задание 2.(убывающая последовательность чисел в массиве):\n");
            Console.WriteLine("Изначальный массив:");
            BubbleSortDecreasing(mass);

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            int[] shellSortedArray2 = new int[mass.Length];
            Array.Copy(mass, shellSortedArray2,mass.Length);

            Stopwatch stopwatch2 = new Stopwatch();

            stopwatch2.Start();

            shell(shellSortedArray2);

            stopwatch2.Stop();

            Console.WriteLine("\n\nМассив после сортировки Шелла: ");
            
            for (int i = 0; i < shellSortedArray2.Length; i++)
            {
                Console.Write($"{shellSortedArray2[i]} ");
            }
            Console.WriteLine($"\n\nВремя вработы сортировки Шелла: {stopwatch2.Elapsed.TotalMilliseconds}");

            line();

            Console.WriteLine("Изначальный массив:");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            int[] qsSortedArray2 = new int[mass.Length];
            Array.Copy(mass, qsSortedArray2, mass.Length);

            stopwatch2.Start();

            qs(qsSortedArray2, 0, mass.Length - 1);
            stopwatch2.Stop();

            Console.WriteLine("\n\nМассив после быстрой сортировки:");
            for (int i = 0; i < qsSortedArray2.Length; i++)
            {
                Console.Write($"{qsSortedArray2[i]} ");
            }

            Console.WriteLine($"\n\nВремя работы быстрой сортировки: {stopwatch2.Elapsed.TotalMilliseconds}");

            line();

            Console.WriteLine("Изначальный массив:");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            int[] standartSortedArray2 = new int[mass.Length];
            Array.Copy(mass, standartSortedArray2, mass.Length);

            stopwatch2.Start();
            Array.Sort(standartSortedArray2);
            stopwatch2.Stop();

            Console.WriteLine("\n\nМассив после стандартной сортировки:");
            for (int i = 0; i < standartSortedArray2.Length; i++)
            {
                Console.Write($"{standartSortedArray2[i]} ");
            }

            Console.WriteLine($"\n\nВремя работы стандартной сортировки: {stopwatch2.Elapsed.TotalMilliseconds}");

            line();
            stop();

            Console.WriteLine("Задание 3.(возростающая последовательность чисел в массиве):\n");
            Console.WriteLine("Изначальный массив:");
            BubbleSortIncreasing(mass);
            
            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            int[] shellSortedArray3 = new int[mass.Length];
            Array.Copy(mass, shellSortedArray3, mass.Length);

            Stopwatch stopwatch3 = new Stopwatch();

            stopwatch3.Start();

            shell(shellSortedArray3);

            stopwatch3.Stop();

            Console.WriteLine("\n\nМассив после сортировки Шелла: ");

            for (int i = 0; i < shellSortedArray3.Length; i++)
            {
                Console.Write($"{shellSortedArray3[i]} ");
            }
            Console.WriteLine($"\n\nВремя вработы сортировки Шелла: {stopwatch3.Elapsed.TotalMilliseconds}");

            line();

            Console.WriteLine("Изначальный массив:");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            int[] qsSortedArray3 = new int[mass.Length];
            Array.Copy(mass, qsSortedArray3, mass.Length);

            stopwatch3.Start();

            qs(qsSortedArray3, 0, mass.Length - 1);
            stopwatch3.Stop();

            Console.WriteLine("\n\nМассив после быстрой сортировки:");
            for (int i = 0; i < qsSortedArray3.Length; i++)
            {
                Console.Write($"{qsSortedArray3[i]} ");
            }

            Console.WriteLine($"\n\nВремя работы быстрой сортировки: {stopwatch3.Elapsed.TotalMilliseconds}");

            line();

            Console.WriteLine("Изначальный массив:");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            int[] standartSortedArray3 = new int[mass.Length];
            Array.Copy(mass, standartSortedArray3, mass.Length);

            stopwatch3.Start();
            Array.Sort(standartSortedArray3);
            stopwatch3.Stop();

            Console.WriteLine("\n\nМассив после стандартной сортировки:");
            for (int i = 0; i < standartSortedArray3.Length; i++)
            {
                Console.Write($"{standartSortedArray3[i]} ");
            }

            Console.WriteLine($"\n\nВремя работы стандартной сортировки: {stopwatch3.Elapsed.TotalMilliseconds}");

            line();
            stop();

            Console.WriteLine("Задание 4.(первая половина эл. - возрастает, вторая половина эл. - убывает):\n");

            for (int i = 0; i < middleIndex; i++)
            {
                mass[i] = value;
                value++;
            }

            value -= 2;
            for (int i = middleIndex; i < N; i++)
            {
                mass[i] = value;
                value--;
            }

            Console.WriteLine("Изначальный массив:");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            int[] shellSortedArray4 = new int[mass.Length];
            Array.Copy(mass, shellSortedArray4, mass.Length);

            Stopwatch stopwatch4 = new Stopwatch();

            stopwatch4.Start();

            shell(shellSortedArray4);

            stopwatch4.Stop();

            Console.WriteLine("\n\nМассив после сортировки Шелла: ");

            for (int i = 0; i < shellSortedArray4.Length; i++)
            {
                Console.Write($"{shellSortedArray4[i]} ");
            }
            Console.WriteLine($"\n\nВремя вработы сортировки Шелла: {stopwatch4.Elapsed.TotalMilliseconds}");

            line();

            Console.WriteLine("Изначальный массив:");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            int[] qsSortedArray4 = new int[mass.Length];
            Array.Copy(mass, qsSortedArray4, mass.Length);

            stopwatch4.Start();

            qs(qsSortedArray4, 0, mass.Length - 1);
            stopwatch4.Stop();

            Console.WriteLine("\n\nМассив после быстрой сортировки:");
            for (int i = 0; i < qsSortedArray4.Length; i++)
            {
                Console.Write($"{qsSortedArray4[i]} ");
            }

            Console.WriteLine($"\n\nВремя работы быстрой сортировки: {stopwatch4.Elapsed.TotalMilliseconds}");

            line();

            Console.WriteLine("Изначальный массив:");

            for (int i = 0; i < mass.Length; i++)
            {
                Console.Write($"{mass[i]} ");
            }

            int[] standartSortedArray4 = new int[mass.Length];
            Array.Copy(mass, standartSortedArray4, mass.Length);

            stopwatch4.Start();
            Array.Sort(standartSortedArray4);
            stopwatch4.Stop();

            Console.WriteLine("\n\nМассив после стандартной сортировки:");
            for (int i = 0; i < standartSortedArray4.Length; i++)
            {
                Console.Write($"{standartSortedArray4[i]} ");
            }

            Console.WriteLine($"\n\nВремя работы стандартной сортировки: {stopwatch4.Elapsed.TotalMilliseconds}");

            line();
            stop();
        }

        public static void shell(int[] Array)
        {
            int j;
            int step = Array.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (Array.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (Array[j] > Array[j + step]))
                    {
                        int tmp = Array[j];
                        Array[j] = Array[j + step];
                        Array[j + step] = tmp;
                        j -= step;
                    }
                }
                step = step / 2;
            }
        }
        public static void qs(int[] items, int left, int right)
        {
            int i, j;
            int x, y;

            i = left;
            j = right;

            // Выбор компаранда
            x = items[(left + right) / 2];

            do
            {
                while (items[i] < x && i < right)
                {
                    i++;
                }
                while (x < items[j] && j > left)
                {
                    j--;
                }

                if (i <= j)
                {
                    y = items[i];
                    items[i] = items[j];
                    items[j] = y;
                    i++;
                    j--;
                }
            } while (i <= j);

            if (left < j)
            {
                qs(items, left, j);
            }
            if (i < right)
            {
                qs(items, i, right);
            }
        }
        static void stop()
        {
            Console.ReadLine();
        }
        static void line()
        {
            Console.WriteLine("----------------------------------------");
        }
        static int[] BubbleSortDecreasing(int[] mass)
        {
            int temp;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    if (mass[i] > mass[j])
                    {
                        temp = mass[i];
                        mass[i] = mass[j];
                        mass[j] = temp;
                    }
                }
            }
            return mass;
        }
        static int[] BubbleSortIncreasing(int[] mass)
        {
            int temp;
            for (int i = 0; i < mass.Length; i++)
            {
                for (int j = 0; j < mass.Length; j++)
                {
                    if (mass[i] < mass[j])
                    {
                        temp = mass[j];
                        mass[j] = mass[i];
                        mass[i] = temp;
                    }
                }
            }
            return mass;
        }
    }
}

