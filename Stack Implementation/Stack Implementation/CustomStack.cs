using System;
using System.Collections.Generic;
using System.Text;

namespace Stack_Implementation
{
    class CustomStack
    {
        private string[] array = new string[0];


        public void Push(string value)
        {
            string[] arrayCopy = new string[array.Length + 1];

            array.CopyTo(arrayCopy, 0);
            arrayCopy[arrayCopy.Length - 1] = value;
            array = arrayCopy;
        }

        public string Pop()
        {
            if(array.Length < 1)
            {
                throw new IndexOutOfRangeException("Stack has no values to return.");
            }

            string value = array[array.Length - 1];
            string[] arrayCopy = new string[array.Length - 1];

            for(int i = 0; i < array.Length -1; i++)
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
                throw new IndexOutOfRangeException("Stack has no values to return.");
            }
            
            return array[array.Length - 1];
        }

        public override string ToString()
        {
            string arrayString = "";
            
            for(int i = array.Length - 1; i >= 0; i--)
            {
                arrayString += array[i] + " ";
            }

            return arrayString.Trim(); 
        }
    }
}
