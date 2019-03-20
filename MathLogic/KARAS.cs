using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mass = new double[15, 2]; // эт данные первоначальные с методички
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
            mass[12, 1] = 27.5;
            mass[13, 0] = 38.1;
            mass[13, 1] = 30.5;
            mass[14, 0] = 44.2;
            mass[14, 1] = 30.5;


            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(mass[i, j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            double[,] mas = new double[15, 15];// эт сообственно огромный массив который матрица расстояний между объектами
            int n = 0;// эт переменная нужна чтоб симметричное заполнение можно было фигачить типо растояние от какой точки
            
            while (n != 15)
            {
                int f = 0;// а это до какой 
                for (int j = 0; j < 15; j++)
                {

                    if (mas[n, j] != null)
                    {
                        mas[n, j] = Math.Round(Math.Pow((mass[n, 0] - mass[f, 0]), 2) + Math.Pow((mass[n, 1] - mass[f, 1]), 2), 2);
                        mas[n, j] = mas[n, j];
                      
                    }
                    f++;
                }
                n++;
            }
            for (int i = 0; i < 15; i++)
            {
                for (int j = 0; j < 15; j++)
                {
                    if (mas[i, j] != null)
                    {
                        Console.Write(mas[i, j]);
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            

            for (int i=0;i<15;i++)
            {
                double min = 100;// ну эт минимальная длина
                int y = 0;
                for (int j=0;j<15;j++)
                {
                    if(min>mas[i,j]&& mas[i,j]!=0)
                    {
                        min = mas[i, j];
                        y = j;
                    }
                  
                }
                Console.WriteLine(i);
                Console.WriteLine(y);
                Console.WriteLine(min);
                Console.WriteLine();
            }



            Console.ReadKey();
        }
    }
}
