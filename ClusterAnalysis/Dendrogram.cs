using System;
using System.Collections.Generic;
using System.Linq;

namespace ClusterAnalysis
{
    public class Dendrogram
    {
        private static void addNode_brackets(string str, List<Clusters> clusters, Node parent)
        {
            if (str[0] == '(') // если первый элемент скобка => выражение есть кластер
            {
                int posOne = 0;
                int count = 1;
                int posLast = 0;
                for (posLast = 1; posLast < str.Length - 1; posLast++)
                {
                    if (str[posLast] == '(' && count > 0)
                        count++;
                    if (str[posLast] == ')' && count > 0)
                        count--;
                    if (count == 0)
                        break;
                }

                /*   int posOne = 0;
                   int posLast = 0;
                   int amount = 0;
                   posOne = str.IndexOf('(');
                   string s0 = "(";
                   if (posOne >= 0)
                   {
                       amount = (str.Length - str.Replace(s0, "").Length) / s0.Length;//new Regex("(").Matches(str).Count;
                       for (int i = 0; i < str.Length - 1; i++)
                       {
                           if (str[i] == (')'))
                               posLast = i;
                       }
                   }*/
                string upsidedown = str.Substring(posOne + 1, posLast - 1);
                parent.addLeft(new Node("(" + upsidedown + ")", 1));
                addNode(upsidedown, clusters, parent.LeftChild);
                string twoPart = str.Substring(posLast + 1);
                if (twoPart.Length > 0)
                {
                    if (twoPart[0] != '-' || twoPart.IndexOf('(') >= 0)
                    {
                        if (twoPart[0] == '-')
                        {
                            parent.addRight(new Node(twoPart.Substring(1), 0));
                        }
                        else
                        {
                            parent.addRight(new Node(twoPart, 0));
                        }
                        addNode(twoPart, clusters, parent.RightChild);
                    }
                    else
                    {
                        parent.addRight(new Node(twoPart.Substring(1), 2));
                        // addNode(twoPart, clusters, parent.RightChild); ////////////////////////////////
                    }
                }

            }
            else if (Char.IsNumber(str[0]) && str.IndexOf('-') >= 0)
            {
                int indexDash = str.IndexOf('-');

                parent.addLeft(new Node(str.Substring(0, indexDash), 2));
                parent.addRight(new Node(str.Substring(indexDash + 1), 2));
                addNode(str.Substring(indexDash + 2, str.Length - 3 - indexDash), clusters, parent.RightChild);

            }
            else if (str.IndexOf('-') >= 0) // если первый не скобка, то кластер состоит из одного элемента (или еще одного кластера)
            {
                string part = str.Substring(1);
                int index = part.IndexOf(')');
                if (index >= 0)
                {
                    if (part.IndexOf('(') >= 0)
                    {
                        addNode_brackets(part.Substring(1, part.Length - 2), clusters, parent);
                    }
                    else
                    {
                        part = part.Substring(0, part.Length - (part.Length - index));
                        parent.addRight(new Node(part, 2));
                    }

                }
                else
                {
                    part = part.Substring(0);
                    parent.addRight(new Node(part, 2));
                }


            }
            else // если кластер состоит из двух одиночных элементов, т.е. элементы являются листами дерева
            {
                string[] strsplit = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                parent.addLeft(new Node(strsplit[0], 1));
                //   addNode(strsplit[0], clusters, parent.LeftChild);

                parent.addRight(new Node(strsplit[1], 2));
                //    addNode(strsplit[1], clusters, parent.RightChild);

            }
        }
        private static void addNode(string str, List<Clusters> clusters, Node parent)
        {
            //  int a = (1 - ((3 - (5, 9)) - 6)) - ((2 - (8, 13)) - ((4, 12) - (7 - (10, 11))));
            //   str = "-(2,1)";
            //   str = "1-((3-(5,9))-6)";
            if (str[0] == '(') // если первый элемент скобка => выражение есть кластер
            {
                int posOne = 0;
                int count = 1;
                int posLast = 0;
                for (posLast = 1; posLast < str.Length - 1; posLast++)
                {
                    if (str[posLast] == '(' && count > 0)
                        count++;
                    if (str[posLast] == ')' && count > 0)
                        count--;
                    if (count == 0)
                        break;
                }
                /*   int posOne = 0;
                   int posLast = 0;
                   int amount = 0;
                   posOne = str.IndexOf('(');
                   string s0 = "(";
                   if (posOne >= 0)
                   {
                       amount = (str.Length - str.Replace(s0, "").Length) / s0.Length;//new Regex("(").Matches(str).Count;
                       for (int i = 0; i < str.Length - 1; i++)
                       {
                           if (str[i] == (')'))
                               posLast = i;
                       }
                   }*/
                string upsidedown = str.Substring(posOne + 1, posLast - 1);
                parent.addLeft(new Node("(" + upsidedown + ")", 0));
                addNode(upsidedown, clusters, parent.LeftChild);


                string twoPart = str.Substring(posLast + 1);
                if (twoPart.Length > 0)
                {
                    if (twoPart[0] != '-' || twoPart.IndexOf('(') >= 0)
                    {
                        if (twoPart[0] == '-')
                        {
                            parent.addRight(new Node(twoPart.Substring(1), 0));
                        }
                        else
                        {
                            parent.addRight(new Node(twoPart, 0));
                        }
                        addNode(twoPart, clusters, parent.RightChild);
                    }
                    else
                    {
                        parent.addRight(new Node(twoPart.Substring(1), 2));
                        // addNode(twoPart, clusters, parent.RightChild); ////////////////////////////////
                    }
                }


            }
            else if (Char.IsNumber(str[0]) && str.IndexOf('-') >= 0)
            {
                int indexDash = str.IndexOf('-');

                parent.addLeft(new Node(str.Substring(0, indexDash), 2));
                parent.addRight(new Node(str.Substring(indexDash + 1), 2));
                addNode(str.Substring(indexDash + 2, str.Length - 3 - indexDash), clusters, parent.RightChild);

            }
            else if (str.IndexOf('-') >= 0) // если первый не скобка, то кластер состоит из одного элемента (или еще одного кластера)
            {
                string part = str.Substring(1);
                int index = part.IndexOf(')');
                if (index >= 0)
                {
                    if (part.IndexOf('(') >= 0)
                    {
                        addNode_brackets(part.Substring(1, part.Length - 2), clusters, parent);
                    }
                    else
                    {
                        part = part.Substring(0, part.Length - (part.Length - index));
                        parent.addRight(new Node(part, 2));
                    }

                }
                else
                {
                    part = part.Substring(0);
                    parent.addRight(new Node(part, 2));
                }


            }
            else // если кластер состоит из двух одиночных элементов, т.е. элементы являются листами дерева
            {
                string[] strsplit = str.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries);

                parent.addLeft(new Node(strsplit[0], 1));
                //   addNode(strsplit[0], clusters, parent.LeftChild);

                parent.addRight(new Node(strsplit[1], 2));
                //    addNode(strsplit[1], clusters, parent.RightChild);

            }



        }
        private static void setValueX(Node root)
        {
            if (root != null)
            {
                if (root.LeftChild != null)
                {
                    setValueX(root.LeftChild);
                    setValueX(root.RightChild);
                    if (root.LeftChild.X != 0 && root.RightChild.X != 0)
                        root.X = (root.LeftChild.X + root.RightChild.X) / 2;
                }
            }
        }
        private static void setValueY(Node root, List<Clusters> clusters)
        {
            if (root != null)
            {
                foreach (var item in clusters)
                {
                    if (root.lable == item.label)
                        root.Y = item.value;
                }
                if (root.LeftChild != null)
                {
                    setValueY(root.LeftChild, clusters);
                    setValueY(root.RightChild, clusters);
                }
            }
        }
        public static void createTree(Node root, string str, List<Clusters> clusters)
        {


            root.lable = clusters.Last().label;
            root.Y = clusters.Last().value;
            root.isNode = true;

            addNode(str.Substring(1, str.Length - 2), clusters, root);

            root.bypass(root);

            setValueY(root, clusters);
            setValueX(root);
            while (root.X == 0)
            {
                setValueX(root);
            }

        }
    }
}
