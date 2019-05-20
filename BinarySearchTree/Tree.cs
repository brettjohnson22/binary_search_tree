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
            while(true)
            {
                if (data < node.data)
                {
                    while (node.leftBranch != null)
                    {
                        node = node.leftBranch;
                        break;
                    }
                }
                if (data >= node.data)
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
                if (node.rightBranch == null && data >= node.data)
                {
                    node.rightBranch = temp;
                    return;
                }
            }
        }
        public bool Search(int data)
        {
            bool found = false;
            Node node;
            if (root == null)
            {
                return found;
            }
            node = root;
            while(true)
            {
                if (data < node.data)
                {
                    while (node.leftBranch != null)
                    {
                        node = node.leftBranch;
                        break;
                    }
                    while (node.rightBranch != null && data > node.rightBranch.data)
                    {
                        node = node.rightBranch;
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
                    while (node.leftBranch != null && data < node.leftBranch.data)
                    {
                        node = node.leftBranch;
                        break;
                    }
                }
                if (node.leftBranch == null && data < node.data)
                {
                    return found;
                }
                if (node.rightBranch == null && data > node.data)
                {
                    return found;
                }
                if (data == node.data)
                {
                    found = true;
                    return found;
                }
            }
        }
    }
}