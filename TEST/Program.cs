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
            Console.Write("Введите размер квадратной матрицы: ");
            //Вводим и читаем размер
            int r = Convert.ToInt16(Console.ReadLine());
            //создаём
            int[,] Matrix = new int[r, r];

            //заполняем случайными числами от 0 до 100
            Random random = new Random();
            int rand;
            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < r; j++)
                {
                    rand = random.Next(0, 100);
                    Matrix[i, j] = rand;
                }
            }

        }
    }
}
