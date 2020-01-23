using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Implementation
{
    class CustomQueue
    {
        private string[] array = new string[0];


        public void Enqueue(string value)
        {
            
            string[] arrayCopy = new string[array.Length + 1];

            array.CopyTo(arrayCopy, 1);
            arrayCopy[0] = value;
            array = arrayCopy;
            
        }

        public string Dequeue()
        {
            if (array.Length < 1)
            {
                throw new IndexOutOfRangeException("Queue has no values to return.");
            }

            string value = array[array.Length - 1];
            string[] arrayCopy = new string[array.Length - 1];

            for (int i = 0; i < arrayCopy.Length; i++)
            {
                arrayCopy[i] = array[i];
            }
            array = arrayCopy;
            return value;

        }

        public string Peek()
        {
            if (array.Length < 1)
            {
                throw new IndexOutOfRangeException("Queue has no values to return.");
            }

            return array[array.Length - 1];
        }

        public override string ToString()
        {
            string arrayString = "";

            for (int i = array.Length - 1; i >= 0; i--)
            {
                arrayString += array[i] + " ";
            }

            return arrayString.Trim();
        }
    }
}

