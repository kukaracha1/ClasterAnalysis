using System;

namespace ClusterAnalysis
{
    public class KRAB_Line
    {
        public PointC start;
        public int lableStart;
        public int lableEnd;
        public PointC end;

        public double value;

        public KRAB_Line(PointC start, PointC end, double value, int lableStart, int lableEnd)
        {
            this.start = start;
            this.end = end;
            this.value = value;
            this.lableStart = lableStart;
            this.lableEnd = lableEnd;
        }
        public KRAB_Line(PointC A, PointC B)
        {
            this.start = A;
            this.end = B;
            value = Math.Pow((A.X - B.X), 2) + Math.Pow((A.Y - B.Y), 2);
        }
    }
}
