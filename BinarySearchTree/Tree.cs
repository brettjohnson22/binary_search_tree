using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Tree
    {
        //membervariables (HAS A)
        Node root;

        //constructor (SPAWNER)
        public Tree()
        {
            root = null;
        }

        //member methods (CAN DO)
        public void Add(int data)
        {
            Node node;
            Node temp = new Node(data);
            if (root == null)
            {
                root = temp;
                return;
            }
            node = root;
            while ((node.leftBranch != null && node.rightBranch != null) || (data < node.data && node.leftBranch == null) || (data > node.data && node.rightBranch == null))
            {
                if (data < node.data)
                {
                    while (node.leftBranch != null)
                    {
                        node = node.leftBranch;
                        break;
                    }
                }
                if (data > node.data)
                {
                    while (node.rightBranch != null)
                    {
                        node = node.rightBranch;
                        break;
                    }
                }
                if (node.leftBranch == null && data < node.data)
                {
                    node.leftBranch = temp;
                    return;
                }
                if (node.rightBranch == null && data > node.data)
                {
                    node.rightBranch = temp;
                    return;
                }
            }
        }
    }
}

