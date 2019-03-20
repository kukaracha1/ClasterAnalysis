using System;
using System.Collections.Generic;

namespace ClusterAnalysis
{
    public class CAnalysis
    {
        public static List<PointC> PointCs = new List<PointC>();
        public static List<PointC> centers = new List<PointC>();
        public static List<List<PointC>> result = new List<List<PointC>>();
        public static List<string> nextHope = new List<string>();
        public static List<PointC> Forel(List<PointC> PointCs, int START, int Radius)
        {
            nextHope.Clear();
            START--;
            List<PointC> points = new List<PointC>(PointCs);
            PointC center = new PointC(0, 0);
            PointC newCenter = new PointC(0, 0);
            int NumberCluster = 0;
            while (points.Count > 0)
            {
                if (result.Count == 0)
                {
                    center = points[START];
                    newCenter = center;
                }
                else
                {
                    /* Random rnd = new Random();
                     var index = rnd.Next(0, points.Count);*/
                    //try
                    //{
                    //    int index = Prompt.ShowDialog("ТОЧКА", "Введите точку-эталон для нахождения нового радиуса");
                    //    textBox1.Text += "Для метода Форель следующей выбрана точка [" + (index) + "]" + Environment.NewLine;
                    //    center = points[index - 1];
                    //    newCenter = center;
                    //}
                    //catch(Exception e)
                    //{
                    Random rnd = new Random();
                    var index = rnd.Next(0, points.Count);
                    nextHope.Add("Для метода Форель следующей выбрана точка [" + ((PointCs.IndexOf(points[index])) + 1) + "]" + Environment.NewLine);
                    center = points[index];
                    newCenter = center;
                }

                //точки внутри окружности
                List<PointC> lst = new List<PointC>();
                //точки внутри окр два
                List<PointC> lst2 = new List<PointC>();
                while (center == newCenter)
                {
                    foreach (var p in points)
                    {
                        // textBox1.Text += "Точка " + p.X + " " + p.Y + " Расстояние=" + Math.Sqrt(Math.Pow((p.X - center.X), 2) + Math.Pow((p.Y - center.Y), 2))+Environment.NewLine;
                        if (Math.Sqrt(Math.Pow((p.X - center.X), 2) + Math.Pow((p.Y - center.Y), 2)) < Radius)
                        {
                            p.mark = NumberCluster;
                            lst.Add(p);
                        }
                    }
                    //находим центр
                    double powerX = 0;
                    double powerY = 0;
                    foreach (var p in lst)
                    {
                        powerX += p.X;
                        powerY += p.Y;
                    }
                    double powerCenterX = powerX / lst.Count;
                    double powerCenterY = powerY / lst.Count;
                    newCenter = new PointC(powerCenterX, powerCenterY);
                    foreach (var p in points)
                    {
                        if (Math.Sqrt(Math.Pow((p.X - newCenter.X), 2) + Math.Pow((p.Y - newCenter.Y), 2)) < Radius)
                        {
                            p.mark = NumberCluster;
                            lst2.Add(p);
                        }
                    }

                }
                NumberCluster++;
                result.Add(lst);
                centers.Add(newCenter);
                foreach (var p in lst2)
                {
                    points.Remove(p);
                }
            }
            return centers;
        }

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

        public static List<KRAB_Line> KRAB_ALIVE(List<PointC> pointFs)
        {
            PointC minA = null;
            PointC minB = null;
            double minLength = double.MaxValue;

            List<KRAB_Line> CrabLins = new List<KRAB_Line>();

            foreach (var A in pointFs)
            {
                foreach (var B in pointFs)
                {
                    if (A != B && LengthLineSqr(A, B) < minLength)
                    {
                        minLength = LengthLineSqr(A, B);
                        minA = A;
                        minB = B;
                    }
                }
            }
            CrabLins.Add(new KRAB_Line(minA, minB));
            List<PointC> CrabPoints = new List<PointC>();
            CrabPoints.Add(minA);
            CrabPoints.Add(minB);
            while (CrabPoints.Count != pointFs.Count)
            {
                minLength = double.MaxValue;
                foreach (var A in CrabPoints)
                {
                    foreach (var B in pointFs)
                    {
                        if (A != B && CrabPoints.FindIndex(p => p.Equals(B)) == -1 && minLength > LengthLineSqr(A, B))
                        {
                            minLength = LengthLineSqr(A, B);
                            minA = A;
                            minB = B;
                        }
                    }
                }
                CrabPoints.Add(minB);
                CrabLins.Add(new KRAB_Line(minA, minB));
            }
            return CrabLins;
        }

        private static double LengthLineSqr(PointC A, PointC B)
        {
            return Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2);
        }
    }
}
