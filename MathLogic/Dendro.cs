using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] mass = new double[15, 2];
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


            for (int i=0;i<15;i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.Write(mass[i,j]);
                    Console.Write("\t");
                }
                Console.WriteLine();
            }
            double[,] mas = new double[15, 15];
            int n = 0,x=0,y=0;
            double min = 100;
            while(n!=15)
            {
                int f = 0;
                for (int j = 0; j < 15; j++)
                {
                                     
                   
                        if (mas[n, j] != null)
                        {
                            mas[n, j] =Math.Round(Math.Pow((mass[n, 0] - mass[f, 0]),2)  + Math.Pow( (mass[n, 1] - mass[f, 1]),2),2);
                            mas[n, j] = mas[n, j];
                        if(min>mas[n,j]&& n!=j)
                        {
                            min = mas[n, j];
                            x = n;
                            y = j;
                        }
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
                        Console.Write( mas[i, j]);
                        Console.Write("\t");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(min);
            Console.WriteLine(x);
            Console.WriteLine(y);
            int h = 14;
            while(h!=1)
            {
                min = 100;
                n = 0;
                if(x>y)
                {
                    int u = x;
                    x = y;
                    y = u;
                }
                //for (int i = 0; i < h+1; i++)
                //{
                //    mass[i, 0] = mas[i, x];
                //    mass[i, 1] = mas[i, y];
                       
                //}
                double[,] mas1 = new double[h+1, h+1];
                for(int i=0;i<h+1;i++)
                {
                    for(int j=0;j<h+1;j++)
                    {
                        mas1[i, j] = mas[i, j];
                    }
                }
                mas = null;
                mas = new double[h, h];
                for (int i = 0; i < h ; i++)
                {
                    for (int j = 0; j < h ; j++)
                    {
                        mas[i, j] = -10;
                    }
                }
                while (n != h)
                {
                    int o = 0;
                    int u = 0;
                    int f = 0;
                    for (int j = 0; j < h; j++)
                    {
                        if (mas[n, j] < 0)
                        {
                            if (n != x && n < y && j < y && j != x)
                                mas[n, j] = mas1[n, j];
                            else if (j >= y && n < y)
                                mas[n, j] = mas1[n, j + 1];
                            else if (n >= y && j < y)
                                mas[n, j] = mas1[n + 1, j];
                            else if (n >= y && j >= y)
                                mas[n, j] = mas1[n + 1, j + 1];

                            if (j == x)
                            {
                                if (n == j)
                                {
                                    mas[n, j] = 0;
                                }
                                else if (j < y)
                                    mas[n, j] = mas1[n, x] / 2 + mas1[n, y] / 2 + (Math.Abs(mas1[n, x] - mas1[n, y])) / 2;
                                else
                                {
                                    mas[n, j] = mas1[n + 1, x] / 2 + mas1[n + 1, y] / 2 + (Math.Abs(mas1[n + 1, x] - mas1[n + 1, y])) / 2;

                                }
                                mas[j, n] = mas[n, j];
                            }
                        }
                    

                    }
                    n++;



                }

                for (int i = 0; i < h; i++)
                {
                    for (int j = 0; j < h; j++)
                    {
                        if (mas[i, j] != null)
                        {
                            Console.Write(mas[i, j]);
                            Console.Write("\t");
                            if (min > mas[i, j] && i != j)
                            {
                                if (mas[i, j] != 0)
                                {
                                    min = mas[i, j];
                                    x = i;
                                    y = j;
                                }
                            }
                        }
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(min);
                Console.WriteLine(x);
                Console.WriteLine(y);
                h--;

                }

            
            Console.ReadKey();
       }
    }
}
