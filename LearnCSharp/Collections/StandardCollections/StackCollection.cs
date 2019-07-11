using System.Collections.Generic;

namespace LearnCSharp.Collections.StandardCollections
{
    public class StackCollection
    {
        public void StackManipulations()
        {
            //declare the stack
            var myStack = new Stack<int>();

            //push() method adds an item to the top of the stack
            myStack.Push(1);
            myStack.Push(4);
            myStack.Push(3);
            myStack.Push(6);
            myStack.Push(4);

            //pop() method removes and returns the item from the top of the stack
            System.Console.WriteLine(myStack.Pop());

            //peek() method returns the item from top of the stack and it does not make any manipulations/changes to the stack
            System.Console.WriteLine(myStack.Peek());
            System.Console.WriteLine(myStack.Peek());
            System.Console.WriteLine(myStack.Peek());
            System.Console.WriteLine(myStack.Peek());

            System.Console.WriteLine();

            //return elements from the stack
            foreach(int item in myStack)
            {
                System.Console.WriteLine(item);
            }

            /* OP:
                 6
                 3
                 4
                 1
             */
        }
    }
}
