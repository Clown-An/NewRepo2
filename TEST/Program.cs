using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TEST
{
    class MyMatrix
    {
        protected int[,] matrix;
        protected int dim;

        public MyMatrix(int dimension)
        {
            this.dim = dimension;
            this.matrix = new int[dimension, dimension];

            //заполняем случайными числами от 0 до 100
            Random random = new Random();
            int rand;

            for (int i = 0; i < dimension; i++)
            {
                for (int j = 0; j < dimension; j++)
                {
                    rand = random.Next(0, 100);
                    this.matrix[i, j] = rand;
                }
            }
        }

        public void OutMatrix()
        {
            for (int i = 0; i < this.dim; i++)
            {
                for (int j = 0; j < this.dim; j++)
                {
                    Console.Write(this.matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public int MinMatrix()
        {
            int min = this.matrix[0, 0];

            for (int i = 0; i < this.dim; i++)
            {
                for (int j = 0; j < this.dim; j++)
                {
                    if (this.matrix[i, j] < min)
                    {
                        min = this.matrix[i, j];
                    }
                }
            }

            return min;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            //Вводим и читаем размер
            Console.Write("Введите размер квадратной матрицы: ");
            int r = Convert.ToInt16(Console.ReadLine());

            //создаём матрицу
            MyMatrix matrix = new MyMatrix(r);

            // выводим матрицу
            matrix.OutMatrix();
            Console.WriteLine("------------------");

            // поиск минимального элемента
            Console.WriteLine(matrix.MinMatrix());
            
            Console.ReadKey();
        }
    }
}

