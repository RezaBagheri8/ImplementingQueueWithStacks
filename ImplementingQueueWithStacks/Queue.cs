using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementingQueueWithStacks
{
    public class Queue
    {
        public int[] firstStack;
        public int[] secondStack;
        public int size;
        public int topOfFirstStack;
        public int topOfSecondStack;
        public Queue(int sizeOfQueue)
        {
            size = sizeOfQueue;
            firstStack = new int[sizeOfQueue];
            secondStack = new int[sizeOfQueue];
            topOfFirstStack = -1;
            topOfSecondStack = -1;
        }

        public void Enqueue(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("The queue is full!");
            }
            else
            {
                topOfFirstStack++;
                firstStack[topOfFirstStack] = item;
            }

        }

        public void Dequeue()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                topOfSecondStack = -1;
                for (int i = topOfFirstStack; i >= 0; i--)
                {
                    topOfSecondStack++;
                    secondStack[topOfSecondStack] = firstStack[i];
                }

                int result = secondStack[topOfSecondStack];
                Console.WriteLine(result);
                topOfSecondStack--;

                topOfFirstStack = -1;
                for (int i = topOfSecondStack; i >= 0; i--)
                {
                    topOfFirstStack++;
                    firstStack[topOfFirstStack] = secondStack[i];
                }
            }
        }

        public void Print()
        {
            if (IsEmpty())
            {
                Console.WriteLine("The queue is empty!");
            }
            else
            {
                for (int i = 0; i <= topOfFirstStack; i++)
                {
                    Console.WriteLine(firstStack[i]);
                }
            }
        }

        public bool IsEmpty()
        {
            if (topOfFirstStack == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsFull()
        {
            if (topOfFirstStack == (size - 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


    }
}
