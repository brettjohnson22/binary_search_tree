using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            tree.Add(10);
            tree.Add(7);
            tree.Add(15);
            tree.Add(9);
            tree.Add(20);
            tree.Add(12);
            tree.Add(4);
            tree.Add(8);
            tree.Add(13);
            tree.Add(11);
            tree.Add(1);
            tree.Add(2);
            Console.WriteLine(tree);
            Console.ReadLine();
        }
    }
}
