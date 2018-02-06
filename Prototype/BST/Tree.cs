using System;

namespace Prototype.BST
{
    public class Tree<T> where T : IFigure
    {
        public Node<float> root;

        public Tree()
        {
            root = null;
        }

        public void Add(float value)
        {
            Node<float> newNode = new Node<float>(value);

            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node<float> current = root;

                Node<float> parent = null;

                while(current != null)
                {
                    parent = current;

                    if(value < current.value)
                    {
                        current = current.left;
                        if(current == null)
                        {
                            parent.left = newNode;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if(current == null)
                        {
                            parent.right = newNode;
                        }
                    }
                }
            }
        }

        public void InAscOrderTreeDisplay(Node<float> root)
        {
            if (root != null)
            {
                InAscOrderTreeDisplay(root.left);
                Console.Write($" { root.value } ");
                InAscOrderTreeDisplay(root.right);
            }
        }

        public void InDescOrderTreeDisplay(Node<float> root)
        {
            if (root != null)
            {
                InDescOrderTreeDisplay(root.right);
                Console.Write($" { root.value } ");
                InDescOrderTreeDisplay(root.left);
            }
        }

        public bool FindValue(Node<float> root, float value)
        {
            bool found = false;

            while ((root != null) && !found)
            {
                if (value < root.value)
                {
                    root = root.left;
                }
                else if (value > root.value)
                {
                    root = root.right;
                }
                else
                {
                    found = true;
                    break;
                }
                found = FindValue(root, value);
            }
            return found;
        }
    }
}

