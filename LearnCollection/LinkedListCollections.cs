using System;
using System.Collections.Generic;

namespace LearnCollection
{
    class LinkedListCollections
    {
        //Data manipulations with Linkedlist
        public void LinkedListManipulations()
        {
            var nums = new LinkedList<int>();

            nums.AddLast(23);
            nums.AddLast(34);
            nums.AddLast(33);
            nums.AddLast(11);
            nums.AddLast(6);
            nums.AddFirst(9);
            nums.AddFirst(7);

            LinkedListNode<int> node = nums.Find(6);
            nums.AddBefore(node, 5);

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }
        }

        /*        
        $ dotnet run
            7   --> 1
            9   --> 2
            23  --> 3
            34  --> 4
            33  --> 5
            11  --> 6
            5   --> 7
            6   --> 8
        */
    }
}