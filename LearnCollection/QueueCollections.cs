using System;
using System.Collections.Generic;

namespace LearnCollection
{
    class QueueCollections
    {
        public void QueueManipulations()
        {
            //queue of strings is created
            var msgs = new Queue<string>();

            //Enqueue() adds a message to the end of the queue
            msgs.Enqueue("Message 1");
            msgs.Enqueue("Message 2");
            msgs.Enqueue("Message 3");
            msgs.Enqueue("Message 4");
            msgs.Enqueue("Message 5");

            //Dequeue() method removes and returns the item at the beginning of the queue
            Console.WriteLine(msgs.Dequeue());

            //Peek() method returns the next item from the queue, but does not remove it from the collection
            Console.WriteLine(msgs.Peek());
            Console.WriteLine(msgs.Peek());

            Console.WriteLine();

            //Dequeue() method removes the "Message 1" from the collection. The Peek() method does not. 
            //  the "Message 2" remains in the collection
            foreach (string msg in msgs)
            {
                Console.WriteLine(msg);
            }

            /* OP: $ dotnet run
                Message 1
                Message 2
                Message 2

                Message 2
                Message 3
                Message 4
                Message 5
             */
        }
    }
}