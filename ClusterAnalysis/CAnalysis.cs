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
    }
}
