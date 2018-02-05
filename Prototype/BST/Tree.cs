using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.BST
{
    public class Tree
    {
        public Node root;

        public Tree()
        {
            root = null;
        }

        public void Add(float value)
        {
            Node newItem = new Node(value);
            if (root == null)
            {
                root = newItem;
            }
            else
            {
                Node current = root;

                Node parent = null;

                while(current != null)
                {
                    parent = current;

                    if(value < current.value)
                    {
                        current = current.left;
                        if(current == null)
                        {
                            parent.left = newItem;
                        }
                    }
                    else
                    {
                        current = current.right;
                        if(current == null)
                        {
                            parent.right = newItem;
                        }
                    }
                }
            }
        }

        public void InAscOrderTreeDisplay(Node root)
        {
            if (root != null)
            {
                InAscOrderTreeDisplay(root.left);
                Console.Write($" { root.value } ");
                InAscOrderTreeDisplay(root.right);
            }
        }

        public void InDescOrderTreeDisplay(Node root)
        {
            if (root != null)
            {
                InDescOrderTreeDisplay(root.right);
                Console.Write($" { root.value } ");
                InDescOrderTreeDisplay(root.left);
            }
        }

        public bool FindValue(Node root, float value)
        {
            if (root != null)
            {
                FindValue(root.left, value);
                FindValue(root.right, value);
                if (root.value == value)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

