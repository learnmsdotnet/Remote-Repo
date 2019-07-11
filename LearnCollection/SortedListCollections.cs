using System;
using System.Collections.Generic;

namespace LearnCollection
{
    class SortedListCollections
    {
        //Sorting the data in a sorted list
        public void SortingList()
        {
            var sorted = new SortedList<string, int>();

            sorted.Add("coins", 3);
            sorted.Add("books", 41);
            sorted.Add("spoons", 5);

            if (sorted.ContainsKey("books"))
            {
                Console.WriteLine("There are books in the list");
            }

            foreach (var pair in sorted)
            {
                Console.WriteLine(pair);
            }

            /*
            Output:
            $ dotnet run
                There are books in the list
                [books, 41]
                [coins, 3]
                [spoons, 5]
             */
        }
    }
}