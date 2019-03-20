namespace ClusterAnalysis
{
    public class PointC
    {
        public double X;
        public double Y;
        public int visiting;
        public double mark;

        public string province;
        public PointC(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public PointC(PointC pointC)
        {
            X = pointC.X;
            Y = pointC.Y;
            visiting = pointC.visiting;
            mark = pointC.mark;
        }
    }
}
