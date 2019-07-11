using System;
using System.Collections.Generic;

namespace LearnCollection
{
    class StackCollections
    {
        public void StackManipulations()
        {
            //Stack data structure is created
            var myStack = new Stack<int>();

            //Push() method adds an item at the top of the stack
            myStack.Push(1);
            myStack.Push(4);
            myStack.Push(3);
            myStack.Push(6);
            myStack.Push(4);

            //Pop() method removes and returns the item from the top of the stack
            Console.WriteLine(myStack.Pop());

            //Peek() method returns the item from the top of the stack. It does not remove it
            Console.WriteLine(myStack.Peek());
            Console.WriteLine(myStack.Peek());

            Console.WriteLine();

            foreach (int item in myStack)
            {
                Console.WriteLine(item);
            }

            /* OP: $ dotnet run
                4
                6
                6

                6
                3
                4
                1            
             */
        }
    }
}