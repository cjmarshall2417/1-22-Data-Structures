using System;

namespace Stack_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();
            
            for(int i = 1; i <= 10; i++)
            {
                stack.Push(i.ToString());
            }

            Console.WriteLine(stack.Peek());

            Console.WriteLine(stack.ToString());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(stack.Pop());
            }
            

            CustomQueue queue = new CustomQueue();

            Console.WriteLine(queue.ToString());
            for(int i = 1; i <= 10; i++)
            {
                queue.Enqueue(i.ToString());
            }

            Console.WriteLine(queue.ToString());

            queue.Dequeue();
            queue.Dequeue();

            Console.WriteLine(queue.Peek());

            

        }
    }
}
