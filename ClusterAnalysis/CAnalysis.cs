using System;
using System.Collections.Generic;

namespace ClusterAnalysis
{
    public class CAnalysis
    {
        public static List<Clusters> СonsistentClustering(List<PointC> pointFs)
        {
            List<Clusters> clusters = new List<Clusters>();
            int length = pointFs.Count;
            int lengthString = length + 1;
            Objects[,] mass = new Objects[length, 2]; // эт данные первоначальные с методички

            for (int i = 0; i < length; i++)
            {
                mass[i, 0] = new Objects(pointFs[i].X);
                mass[i, 1] = new Objects(pointFs[i].Y);
            }

            string[,] mas = new string[lengthString, lengthString];
            int n = 0, x = 0, y = 0;
            double min = Double.MaxValue;
            for (int i = 0; i < lengthString; i++)
            {
                mas[i, 0] = Convert.ToString(n);
                mas[0, i] = Convert.ToString(n);
                n++;
            }
            n = 1;
            while (n != lengthString)
            {
                int f = 1;
                for (int j = 1; j < lengthString; j++)
                {


                    if (mas[n, j] == null)
                    {
                        mas[n, j] = Convert.ToString(Math.Round(Math.Pow((mass[n - 1, 0].value - mass[f - 1, 0].value), 2) + Math.Pow((mass[n - 1, 1].value - mass[f - 1, 1].value), 2), 2));
                        mas[n, j] = mas[n, j];
                        if (min > Convert.ToDouble(mas[n, j]) && n != j)
                        {
                            min = Convert.ToDouble(mas[n, j]);
                            x = n;
                            y = j;
                        }
                    }
                    f++;
                }
                n++;
            }

            if (mas[x, 0].Length <= 2 && mas[y, 0].Length <= 2)
            {

                //     Console.WriteLine("(" + mas[x, 0] + "," + mas[y, 0] + ")");
                clusters.Add(new Clusters("(" + mas[x, 0] + "," + mas[y, 0] + ")", Convert.ToDouble(mas[x, y])));


            }
            else
            {
                //     Console.WriteLine("(" + mas[x, 0] + "-" + mas[y, 0] + ")");
                clusters.Add(new Clusters("(" + mas[x, 0] + "-" + mas[y, 0] + ")", Convert.ToDouble(mas[x, y])));

            }
            // Console.WriteLine(x);
            //   Console.WriteLine(y);

            while (length != 2)
            {
                min = Double.MaxValue;
                n = 0;
                if (x > y)
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
                String[,] mas1 = new String[length + 1, length + 1];
                for (int i = 0; i < length + 1; i++)
                {
                    for (int j = 0; j < length + 1; j++)
                    {
                        mas1[i, j] = mas[i, j];
                    }
                }
                mas = null;
                mas = new String[length, length];
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        mas[i, j] = Convert.ToString(-10);
                    }
                }
                while (n != length)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (Convert.ToDouble(mas[n, j]) < 0)
                        {
                            if (n == 0 || j == 0)
                            {
                                if (n == x || j == x)
                                {
                                    if (n == x)
                                    {
                                        if (mas1[x, 0].Length <= 2 && mas1[y, 0].Length <= 2)
                                        {
                                            mas[n, j] = "(" + mas1[x, 0] + "," + mas1[y, 0] + ")";

                                        }
                                        else
                                        {
                                            mas[n, j] = "(" + mas1[x, 0] + "-" + mas1[y, 0] + ")";

                                        }
                                    }
                                    if (j == x)
                                    {
                                        if (mas1[n, x].Length <= 2 && mas1[n, y].Length <= 2)
                                        {
                                            mas[n, j] = "(" + mas1[n, x] + "," + mas1[n, y] + ")";

                                        }
                                        else
                                        {
                                            mas[n, j] = "(" + mas1[0, x] + "-" + mas1[0, y] + ")";

                                        }
                                    }
                                }

                                else if (n < y && j < y)
                                {
                                    mas[n, j] = mas1[n, j];

                                }
                                else if (n >= y)
                                {
                                    mas[n, j] = mas1[n + 1, j];
                                }
                                else if (j >= y)
                                {
                                    mas[n, j] = mas1[n, j + 1];
                                }
                            }
                            else if (n != x && n < y && j < y && j != x)
                                mas[n, j] = mas1[n, j];
                            else if (j >= y && n < y)
                                mas[n, j] = mas1[n, j + 1];
                            else if (n >= y && j < y)
                                mas[n, j] = mas1[n + 1, j];
                            else if (n >= y && j >= y)
                                mas[n, j] = mas1[n + 1, j + 1];

                            if (j == x && n != 0 && j != 0)
                            {
                                if (n == j)
                                {
                                    mas[n, j] = Convert.ToString(0);
                                }
                                else if (n < y)
                                    mas[n, j] = Convert.ToString(Convert.ToDouble(mas1[n, x]) / 2 + Convert.ToDouble(mas1[n, y]) / 2 + (Math.Abs(Convert.ToDouble(mas1[n, x]) - Convert.ToDouble(mas1[n, y]))) / 2);
                                else if (n >= y)
                                {
                                    mas[n, j] = Convert.ToString(Convert.ToDouble(mas1[n + 1, x]) / 2 + Convert.ToDouble(mas1[n + 1, y]) / 2 + (Math.Abs(Convert.ToDouble(mas1[n + 1, x]) - Convert.ToDouble(mas1[n + 1, y]))) / 2);

                                }

                            }
                            else if (n == x && n != 0 && j != 0)
                            {
                                if (n == j)
                                {
                                    mas[n, j] = Convert.ToString(0);
                                }
                                else if (j < y)
                                    mas[n, j] = Convert.ToString(Convert.ToDouble(mas1[x, j]) / 2 + Convert.ToDouble(mas1[y, j]) / 2 + (Math.Abs(Convert.ToDouble(mas1[x, j]) - Convert.ToDouble(mas1[y, j]))) / 2);
                                else if (j >= y)
                                {
                                    mas[n, j] = Convert.ToString(Convert.ToDouble(mas1[x, j + 1]) / 2 + Convert.ToDouble(mas1[y, j + 1]) / 2 + (Math.Abs(Convert.ToDouble(mas1[x, j + 1]) - Convert.ToDouble(mas1[y, j + 1]))) / 2);

                                }

                            }

                        }


                    }
                    n++;



                }

                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < length; j++)
                    {
                        if (mas[i, j] != null)
                        {
                            //          Console.Write(mas[i, j]);
                            //        Console.Write("\t");
                            if (i > 0 && j > 0)
                            {
                                if (min > Convert.ToDouble(mas[i, j]) && i != j)
                                {
                                    if (Convert.ToDouble(mas[i, j]) != 0)
                                    {
                                        min = Convert.ToDouble(mas[i, j]);
                                        x = i;
                                        y = j;
                                    }
                                }
                            }
                        }
                    }
                    //       Console.WriteLine();
                }
                //   Console.WriteLine(min);
                if (mas[x, 0].Length <= 2 && mas[y, 0].Length <= 2)
                {
                    //   Console.WriteLine("(" + mas[x, 0] + "," + mas[y, 0] + ")");
                    clusters.Add(new Clusters("(" + mas[x, 0] + "," + mas[y, 0] + ")", Convert.ToDouble(mas[x, y])));
                }
                else
                {
                    //   Console.WriteLine("(" + mas[x, 0] + "-" + mas[y, 0] + ")");
                    clusters.Add(new Clusters("(" + mas[x, 0] + "-" + mas[y, 0] + ")", Convert.ToDouble(mas[x, y])));

                }
                //  Console.WriteLine(x);
                //  Console.WriteLine(y);
                length--;

            }

            return clusters;
        }
    }
}
