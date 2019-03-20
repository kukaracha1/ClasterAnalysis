using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mass = new double[15, 2];// первоначальные данные с методы
            mass[0, 0] = 41.5;
            mass[0, 1] = 26.5;
            mass[1, 0] = 42.3;
            mass[1, 1] = 24.5;
            mass[2, 0] = 42;
            mass[2, 1] = 24.5;
            mass[3, 0] = 38.2;
            mass[3, 1] = 25.5;
            mass[4, 0] = 39.3;
            mass[4, 1] = 26.0;
            mass[5, 0] = 41.5;
            mass[5, 1] = 29.5;
            mass[6, 0] = 45.5;
            mass[6, 1] = 30;
            mass[7, 0] = 39.5;
            mass[7, 1] = 30.5;
            mass[8, 0] = 42;
            mass[8, 1] = 30.5;
            mass[9, 0] = 49.8;
            mass[9, 1] = 30.5;
            mass[10, 0] = 39.2;
            mass[10, 1] = 31.0;
            mass[11, 0] = 41.9;
            mass[11, 1] = 27;
            mass[12, 0] = 45.6;
            mass[12, 1] = 38.1;
            mass[13, 0] = 38.1;
            mass[13, 1] = 30.5;
            mass[14, 0] = 44.2;
            mass[14, 1] = 30.5;
             //центр мать вашу)) 
            double x=0, y=0;// собственно центр круга
            List<double> numbers = new List<double>() ; // лист для хранения точек которые уже входяк в какой-то круг
            int R = 4;// радиус тип
            for (int i = 0; i < 15; i++)// рассчитываем новый центр
            {
                x += mass[i, 0];
                y += mass[i, 1];
            }
            x = x / 15;//центр круга 
            y = y / 15;
            double X1 = x;// переменные чтоб проверять что центр не повторяется
            double Y1 = y;
            Console.WriteLine(x);
            Console.WriteLine(y);
            //медот
            int o = 0;
            while (numbers.Count() != 15)
            {
                o++;
                double[] mas = new double[15];
                for (int i = 0; i < 15; i++)
                {
                    mas[i] = Math.Sqrt(Math.Pow(x - mass[i, 0], 2) + Math.Pow(y - mass[i, 1], 2));
                }
                for (int i = 0; i < 15; i++)
                {
                    Console.WriteLine(mas[i]);
                }

                for (int i = 0; i < 15; i++)
                {
                    if (mas[i] <= R)
                    {
                        numbers.Sort();// сортировка листа иначе поиск не делается
                        int h = numbers.BinarySearch(i);// собственно поиск
                        if (h < 0)
                        {
                            numbers.Add(i);// добавление точк в лист
                        }
                    }
                }
                Console.WriteLine(numbers);
                int j = 0;
                x = 0; y = 0;
                for (int i = 0; i < 15; i++)
                {
                    numbers.Sort();
                    int h = numbers.BinarySearch(i);
                    if (h < 0)
                    {
                        j++;
                        x += mass[i, 0];
                        y += mass[i, 1];
                    }
                }

                x = x / j;// новый радиус
                y = y / j;
                if (x == X1 && y == Y1)// проверям чтоб радиус не повторялся 
                {
                    for (int i = 0; i < 15; i++)
                    {
                        numbers.Sort();
                        int h = numbers.BinarySearch(i);
                        if (h < 0)// если повторяется берем первую точку которая не входит в лист
                        {

                            x = mass[i, 0];
                            y = mass[i, 1];
                            break;
                        }
                    }
                }
                else
                {
                    X1 = x;
                    Y1 = y;
                }
                Console.WriteLine(x);
                Console.WriteLine(y);
                Console.WriteLine(o);
            }
            Console.ReadKey();
        }

    }
}
