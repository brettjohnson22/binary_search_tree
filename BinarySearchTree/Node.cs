using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Node
    {
        //membervariables (HAS A)
        public int data;
        public Node leftBranch; //less than
        public Node rightBranch; // greather than

        //constructor (SPAWNER)
        public Node(int data)
        {
            this.data = data;
            leftBranch = null;
            rightBranch = null;
        }

        //member methods (CAN DO)
    }
}
