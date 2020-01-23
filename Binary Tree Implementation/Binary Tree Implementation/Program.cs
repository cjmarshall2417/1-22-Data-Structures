using System;
using System.Collections.Generic;

namespace Binary_Tree_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTreeNode root = new BinaryTreeNode(1);
            root.left = new BinaryTreeNode(2);
            root.right = new BinaryTreeNode(3);
            root.left.left = new BinaryTreeNode(4);
            root.left.right = new BinaryTreeNode(5);

            Console.WriteLine(root.Sum());

            root.Traverse();

            List<int> list = new List<int>();
            root.toList(list);

            Console.WriteLine(list.Count);

        }
    }
}
