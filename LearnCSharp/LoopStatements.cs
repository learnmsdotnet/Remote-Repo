using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class LoopStatements
    {
        /// <summary>
        /// Understanding for .. loop
        /// </summary>
        public void UnderstandingForLoop()
        {
            //logic: lets print the values in the screen from 0 to 9
            /* 1
             * 2
             * 3
             * 4
             * 5
             * 6
             * 7
             * 8
             * 9
             * 
             * the current value is: 1
             * the current value is: 2
             * the current value is: 3
             * the current value is: 4
             * ..
             * the current value is: 9
             */

            //for (variable initialization; condition; steps)
            //{
            //        //code that will be execuited as long as the <condition> inside the loop is satisfied
            //}

            for (int i = 0; i < 10; i++)
            {
                //if the condition (i < 10) is true

                //1st Part
                //in memory the execuition will start from left and proceed to right
                //int i = 0

                //2nd Part
                //condition check happens
                //i < 10 (the current value of i should be less than 10)
                //0 < 10 (condition is satisfied)

                //3rd Part
                //{ } -- code segment inside the for loop will be execuited

                //4th Part
                //control again moves to increment or decrement part of the loop
                //i++ (to the existing value of i add 1 to it eg: i = 1 then i = i + 1 --> i = 2

                Console.WriteLine("the current value is: {0}", i);
            }

            //if the condition (i < 10) is false 
            Console.WriteLine("for loop is exited when the value of i is 10 - condition is not satisfied");
        }

        /// <summary>
        /// Combining Loop and Conditional stmt
        /// </summary>        
        public void UnderstandingForLoopCondStmt()
        {
            //the current value is: 1
            //..
            //the current value is: 9

            int i = 0;

            for (; ; ) //New (infinite loop)
            {
                if (i < 10)
                {
                    Console.WriteLine("the current value is: {0}", i);
                    i++;
                    //i = i + 1;
                }
                else
                    break; //New
                //on seeing the break for loop exists and control comes outside (infinite loop is terminated)
            }

        }

        /// <summary>
        /// For loop using double datatype
        /// </summary>
        public void ForLoopUsingDoubleDataType()
        {
            //value of i: 1.01
            //value of i: 1.02
            //..
            //value of i: 1.09

            for (double d = 1.01D; d < 1.10D; d += 0.01D)
            {
                Console.WriteLine("value of i: {0}", d);
            }
        }

        /// <summary>
        /// Print the values in descending order
        /// </summary>
        public void ForLoopDecrementPrintInReverse()
        {
            //Output: 
            /*  10
             *  9
             *  8
             *  7
             *  6
             *  5
             *  4
             *  3
             *  2
             *  1
             */

            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }
        }

        /// <summary>
        /// Nesting of for loop (forloop inside another forloop)
        /// </summary>
        public void NestingOfForLoop()
        {
            /* Output:
             * value of i: 0, j: 0
             * value of i: 0, j: 1
             * value of i: 0, j: 2
             ...
             * value of i: 0, j: 9
             * value of i: 1, j: 1

             */

            for (int i = 0; i < 10; i++)
            {
                for (int j = i; j < 10; j++)
                {
                    Console.WriteLine("the value of i: {0} and j: {1}", i, j);
                }
            }
        }

        /// <summary>
        /// Understanding while loop print the values from 0 to 9 using while loop
        /// </summary>
        public void UnderstandingWhileLoop()
        {
            //logic: we need to print the values from 0 to 9 using while loop and the values should be prefixed with 
            //  value of i: x

            //Declared an integer variable and assinged value to it
            int i = 0;

            //(i < 10): unless the value of i is less than 10 execuite the statements inside the while loop
            while (i < 10)
            {
                //when the condition is true the statements inside the while loop will be execuited
                Console.WriteLine("Value of i: {0}", i);

                //i = i + 1;
                i++;

                //i = i + 2;
                //i+=2;
            }

        }

        /// <summary>
        /// Understanding the while loop and using the break statement
        /// </summary>
        public void WhileLoopWithBreakStmt()
        {
            //logic: we need to print the values from 0 to 9 using while loop and the values should be prefixed with 
            //  Value of i: x

            /* Value of i: 0
               Value of i: 1
               Value of i: 2
               ..
               ..
               Value of i: 9
             */

            int i = 0;

            while (true) //(for loop equivalent) for (;;)
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;

                if (i > 10) //this condition will not be statisfied unless the value of i reaches 9
                    break;  //when a break stmt is execuited the flow of while loop will terminate and the control 
                            //  will come outside the while loop (reach line number: 211)
            }
        }

        /// <summary>
        /// Understanding do while loop and using it print the values from 0 to 9
        /// </summary>
        public void UnderstandingDoWhileLoop()
        {
            //logic: we need to print the values from 0 to 9 using while loop and the values should be prefixed with 
            //  Value of i: x

            int i = 0;

            //do this until the condition is true
            do
            {
                //this ...
                Console.WriteLine("Value of i: {0}", i);

                i++;

            } while (i < 10); //until the value of i is less than 10 execuite the values inside the do loop
        }

        /// <summary>
        /// Understanding do .. while loop during negative condition
        /// </summary>
        public void UnderstandingDoWhileLoopFalseCondition()
        {
            //logic: we need to print the values from 0 to 9 using while loop and the values should be prefixed with 
            //  Value of i: x

            int i = 0;

            //do this until the condition is true
            do
            {
                //this ...
                Console.WriteLine("Value of i: {0}", i);

                i++;

            } while (i < 0); //the condition which we have set at the initial time is failing the loop will be executed once
        }

        /// <summary>
        /// Understanding do .. while loop using break statement
        /// </summary>
        public void DoWhileLoopWithBreakStmt()
        {
            //logic: we need to print the values from 0 to 9 using while loop and the values should be prefixed with 
            //  Value of i: x

            /* Value of i: 0
               Value of i: 1
               Value of i: 2
               ..
               ..
               Value of i: 5
             */

            int i = 0;

            do
            {
                Console.WriteLine("Value of i: {0}", i);

                i++;

                if (i > 5) //this condition will not be statisfied unless the value of i reaches 4 (1st check: 0 greater than 5 -> false)
                    break;  //when a break stmt is execuited the flow of while loop will terminate and the control 
                            //  will come outside the while loop

            } while (true);
        }
    }
}
