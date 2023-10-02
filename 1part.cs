using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;
namespace example
{
    internal class Program
    {
        static int tableWidth = 60;
        static void Main()
        {
            int[] matrixSizes = { 100, 200, 400, 1000, 2000, 4000, 10000 };

            Console.WriteLine(new string('-', 55));
            PrintRow("Matrix Size", "Elapsed Time (s)");
            Console.WriteLine(new string('-', 55));

            foreach (int size in matrixSizes)
            {
                int[,] matrix1 = GenerateRandomMatrix(size, size);
                int[,] matrix2 = GenerateRandomMatrix(size, size);

                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();

                int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);

                stopwatch.Stop();
                TimeSpan elapsedTime = stopwatch.Elapsed;

                PrintRow($"{size}x{size}", elapsedTime.TotalSeconds.ToString("0.000"));
            }

            Console.WriteLine(new string('-', tableWidth));
        }

        static int[,] GenerateRandomMatrix(int rows, int cols)
        {
            Random random = new Random();
            int[,] matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = random.Next(100);
                }
            }

            return matrix;
        }

        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int cols2 = matrix2.GetLength(1);

            int[,] resultMatrix = new int[rows1, cols2];

            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }

            return resultMatrix;
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length * 3 - 1) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }
    }
}