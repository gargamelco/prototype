using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.BST
{
    public class Node
    {
        public float value;
        public Node left { get; set; }
        public Node right { get; set; }

        public Node(float value)
        {
            this.value = value;
        }
    }
}
