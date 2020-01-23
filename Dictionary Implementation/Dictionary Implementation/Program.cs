using System;

namespace Dictionary_Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomDictionary dictionary = new CustomDictionary();

            dictionary.Add("yellow", "bus");
            dictionary.Add("red", "firetruck");
            dictionary.Add("blue", "sky");

            Console.WriteLine(dictionary["blue"]);

            var matchingKeys = dictionary.FindKeys("firetruck");

            foreach(string value in matchingKeys)
            {
                Console.WriteLine(value);
            }

            Console.WriteLine(dictionary.ToString());
            

        }
    }
}
