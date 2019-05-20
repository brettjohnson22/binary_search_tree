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
            int[] tester = new int[17] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 20, 25 };
            foreach(int number in tester)
            {
                bool found = tree.Search(number);
                Console.Write($"Found {number}? {found}\n");
            }
            Console.ReadLine();
            
        }
    }
}
