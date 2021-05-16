using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class Program
    {
        static void Main(string[] args)
        {

            //Вводим и читаем размер
            Console.Write("Введите размер квадратной матрицы: ");
            int r = Convert.ToInt16(Console.ReadLine());

            //создаём матрицу
            int[,] Matrix = CreateMatrix(r);
            
            // выводим матрицу
            OutMatrix(Matrix);
            Console.WriteLine("------------------");

            // поиск минимального элемента
            Console.WriteLine(MinMatrix(Matrix));
            
            Console.ReadKey();
        }


        public static int MinMatrix(int[,] matrix)
        {
            int n = (int)Math.Sqrt(matrix.Length);
            int min = matrix[0, 0];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < min)
                    {
                        min = matrix[i, j];
                    }
                }
            }

            return min;
        }


        public static void OutMatrix(int[,] matrix)
        {
            int n = (int)Math.Sqrt(matrix.Length);

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }


        public static int[,] CreateMatrix(int n)
        {
            int[,] Matrix = new int[n, n];

            //заполняем случайными числами от 0 до 100
            Random random = new Random();
            int rand;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    rand = random.Next(0, 100);
                    Matrix[i, j] = rand;
                }
            }

            return Matrix;
        }

    }
}

