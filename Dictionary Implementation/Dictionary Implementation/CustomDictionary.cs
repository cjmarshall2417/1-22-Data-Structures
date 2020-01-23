using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary_Implementation
{
    class CustomDictionary
    {
        private List<string> keys = new List<string>();
        private List<string> values = new List<string>();

        public string this[string key]
        {
            get {
                for(int i = 0; i < keys.Count; i++)
                {
                    if(keys[i] == key)
                    {
                        return values[i];
                    }
                }

                throw new Exception("The key " + key + " was not found.");
            }
        }

        public void Add(string key, string value)
        {
            if(keys.Contains(key))
            {
                throw new Exception("Dictionary can not has duplicate keys, " + key + " already exists as a key in dictionary.");
            }
            else
            {
                keys.Add(key);
                values.Add(value);
            }
        }

        public List<string> Keys()
        {
            return keys;
        }

        public List<string> Values()
        {
            return values;
        }

        public bool ContainsKey(string key)
        {
            return keys.Contains(key);
        }

        public bool ContainsValue(string value)
        {
            return values.Contains(value);
        }

        //returns a list of keys that has the supplied value
        public List<string> FindKeys(string value)
        {
            List<string> matchingKeys = new List<string>();
            
            for(int i = 0; i < keys.Count; i++)
            {
                if(values[i] == value)
                {
                    matchingKeys.Add(keys[i]);
                }
            }

            return matchingKeys;
        }

        public override string ToString()
        {
            string result = "";
            for(int i = 0; i < keys.Count; i++)
            {
                result += "Key: " + keys[i] + " Value: " + values[i] + "\n";
            }

            return result;
        }




    }
}
