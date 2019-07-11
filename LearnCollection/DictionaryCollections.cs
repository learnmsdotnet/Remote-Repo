using System;
using System.Collections.Generic;

namespace LearnCollection
{
    class DictionaryCollections
    {
        public void DictionaryOperations()
        {
            //Create a dictionary variable to map domain name and country names (create a dictionary with string keys and values)
            var domains = new Dictionary<string, string>();
            
            //The first string is the key. The second is the value
            domains.Add("de", "Germany");
            domains.Add("sk", "Slovakia");
            domains.Add("us", "United States");
            domains.Add("ru", "Russia");
            domains.Add("hu", "Hungary");
            domains.Add("pl", "Poland");

            //retrieve two values by their keys.
            Console.WriteLine(domains["sk"]);
            Console.WriteLine(domains["de"]);

            //Print the number of items by referring to the Count property            
            Console.WriteLine("Dictionary has {0} items", domains.Count);

            Console.WriteLine("Keys of the dictionary:");

            //retrieve all keys from the dictionary
            var keys = new List<string>(domains.Keys);
            foreach (string key in keys)
            {
                Console.WriteLine("{0}", key);
            }

            Console.WriteLine("Values of the dictionary:");

            // retrieve all values from the dictionary
            var vals = new List<string>(domains.Values);

            foreach (string val in vals)
            {
                Console.WriteLine("{0}", val);
            }

            Console.WriteLine("Keys and values of the dictionary:");

            //print both keys and values of the dictionary)
            foreach (KeyValuePair<string, string> kvp in domains)
            {
                Console.WriteLine("Key = {0}, Value = {1}",
                    kvp.Key, kvp.Value);
            }
        }
    }
}