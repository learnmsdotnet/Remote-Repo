using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp.Collections.GenericCollections
{
    public class SortedListCollection
    {
        public void SortedList()
        {
            //Declaring a Sorted List
            var sorted = new SortedList<string, int>();

            //Datatype of the Key is string
            //Datatype of the Value is int

            //         <Key, Value>
            sorted.Add("coins", 3);
            sorted.Add("books", 41);
            sorted.Add("spoons", 5);

            //check if a key exists in the sortedlist collection
            if (sorted.ContainsKey("books"))
            {
                Console.WriteLine("books - are present in this collection");
            }
            else
            {
                Console.WriteLine("books - are not present in this collection");
            }

            if (sorted.ContainsKey("cars"))
                Console.WriteLine("cars - are present in this collection");
            else
                Console.WriteLine("cars - are not present in this collection");

            if (sorted.ContainsValue(41))
                Console.WriteLine("value 41 - is present in this collection");
            else
                Console.WriteLine("value 41 - is not present in this collection");

            if (sorted.ContainsValue(4))            
                Console.WriteLine("value 4 - is present in this collection");
            else
                Console.WriteLine("value 4 - is not present in this collection");

            //In sorted list value will be sorted based on the key value
            foreach (var pair in sorted)
            {
                //Key along with value will be displayed
                Console.WriteLine(pair);

                Console.WriteLine(pair.Key);
                Console.WriteLine(pair.Value);
            }
        }
    }
}
