using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Collections.GenericCollections
{
    public class DictionaryCollection
    {
        public void DictionaryOperations()
        {
            var domains = new Dictionary<string, string>();

            //          Key , Value
            domains.Add("de", "Germany");
            domains.Add("sk", "Slovakia");
            domains.Add("us", "United States");
            domains.Add("ru", "Russia");
            domains.Add("hu", "Hungary");
            domains.Add("pl", "Poland");

            //retrieve values by their keys
            Console.WriteLine(domains["sk"]);
            Console.WriteLine(domains["de"]);

            //count property
            Console.WriteLine(domains.Count);

            //need all the country codes (keys) from the dictionary
            var keys = new List<string>(domains.Keys);
            foreach(string key in keys)
            {
                Console.WriteLine("Key: {0}", key);
            }

            //need all the countrys (values) from the dictionary
            var values = new List<string>(domains.Values);
            foreach (string value in values)
            {
                Console.WriteLine("Value: {0}", value);
            }

            //retrieve key and value from dictionary
            foreach (KeyValuePair<string, string> kvp in domains)
                Console.WriteLine("Key: {0}, Value: {1}", kvp.Key, kvp.Value);            
        }
    }
}
