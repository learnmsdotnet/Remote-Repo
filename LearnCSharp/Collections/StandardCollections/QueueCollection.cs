using System.Collections.Generic;

namespace LearnCSharp.Collections.StandardCollections
{
    public class QueueCollection
    {
        public void QueueManipulation()
        {
            //save the name of the students waiting to get admit card in college
            //student who comes first to the queue will be the first person to leave the queue with collage admission card

            //declare a queue, it holds string datatype (name of the students)
            var students = new Queue<string>();

            //adding student to the queue as when we they college admission block
            //Enqueue()
            students.Enqueue("Sara");
            students.Enqueue("Ram");
            students.Enqueue("Henry");
            students.Enqueue("Peter");
            students.Enqueue("Emma");

            //Dequeue() method removes and returns the item at the beginning of the queue
            System.Console.WriteLine(students.Dequeue());

            //Peek() method: returns the element from the queue but does not remove it from the collection
            System.Console.WriteLine(students.Peek());
            System.Console.WriteLine(students.Peek());

            foreach(string name in students)
            {
                System.Console.WriteLine(name);
            }

            /* OP: 
             * Sara
             * Ram
             * Henry
             * Peter
             * Emma
             * 
             * Ram
             * Henry
             * Peter
             * Emma
             * 
             * Ram
             * Ram
             * 
             * Ram
             * Henry
             * Peter
             * Emma
             */
        }
    }
}
