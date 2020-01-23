using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Tree_Implementation
{
    class BinaryTreeNode
    {
        public int value { get; set; }
        public BinaryTreeNode left { get; set; }
        public BinaryTreeNode right { get; set; }

        public BinaryTreeNode(int passedValue)
        {
            value = passedValue;
        }
        public BinaryTreeNode(int passedValue, BinaryTreeNode passedLeft)
        {
            value = passedValue;
            left = passedLeft;
        }

        public BinaryTreeNode(int passedValue, BinaryTreeNode passedLeft, BinaryTreeNode passedRight)
        {
            value = passedValue;
            left = passedLeft;
            right = passedRight;
        }

        public void Traverse()
        {
            Console.WriteLine(value.ToString());

            if(left != null && right != null)
            {
                left.Traverse();
                right.Traverse();
            }
            else if(left != null)
            {
                left.Traverse();
            }
            else if(right != null)
            {
                right.Traverse();
            }
        }

        public int Sum(int currentValue = 0)
        {
            currentValue += value;

            if(left != null)
            {
                currentValue = left.Sum(currentValue);
            }
            if(right != null)
            {
                currentValue = right.Sum(currentValue);
            }

            return currentValue;
        }

        public List<int> toList(List<int> list)
        {
            list.Add(value);

            if(left != null)
            {
                left.toList(list);
            }
            if(right != null)
            {
                right.toList(list);
            }

            return list;
        }

        
    }
}
