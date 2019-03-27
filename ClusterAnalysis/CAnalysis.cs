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
