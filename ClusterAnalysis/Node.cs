namespace ClusterAnalysis
{
    public static class Num
    {
        public static double chek = -0.5;

        public static double Chek
        {
            get { return chek; }
            set { chek = value; }
        }
    }
    public class Node
    {
        public string lable;
        public double Y;
        public double X;
        public Node RightChild;
        public Node LeftChild;
        public bool isLeaf;
        public bool isNode;

        public Node()
        { isNode = true; }
        public Node(string lable, double X)
        {
            this.lable = lable;
            this.X = X;
        }
        public void addRight(Node r)
        {
            RightChild = r;
        }
        public void addLeft(Node l)
        {
            LeftChild = l;
        }
        public void bypass(Node r)
        {
            if (r.LeftChild == null)
            {
                Num.Chek = Num.Chek + 1;
                r.X = Num.Chek;
                r.Y = 0;
            }
            else
            {
                r.bypass(r.LeftChild);
            }

            if (r.RightChild == null)
            {

            }
            else
            {
                r.bypass(r.RightChild);
            }
        }
    }
}
