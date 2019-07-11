using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class DailyAssignments
    {
        public void SwitchStatement01()
        {
            /* Assignment:
             * 01. switch statement to be used
	            a. create a variable and assign the value to the variable as "switch"
	            b. there should be 3 cases inside the switch statement
	            c. 1st case: should check if it matches with the string 'if.else' 
	            d. 2nd case: should check if it matches with the string 'ternary' 
	            e. 1st case: should check if it matches with the string 'switch' 
	            f. if a match is identified in any of the switch statment then display the output to console as "switch statement identified"
	            g. 'default' case is not required
                h. change the value of the variable from "switch" to "ternary" and then run the program
                i. change the value of the variable from "ternary" to "if.then.else" and then run the program
                j. include the default case in this method
                k. run the program once again to check the output
             */

            //Code Here
            //...
        }

        public void NestingOfSwitchStatement02()
        {
            /*  1. switch statement need to be used
             *  2. define an interger varaible  //i = 5;
             *  3. evaluate the switch statement //switch (statement)
             *  4. create a case with value as 5 //case 5:
             *  5. inside case 5, display the value 5 in console window
             *  6. create a switch statement inside it with expression (variable defined in step2 - 1) // switch (i - 1)
             *  7. to the nested switch statement inside case 5 create a case with value as 4: //case 4:
             *  8. display the value 4 in console window
             *  9. again create a switch statement inside this case expression (variable defined in step2 - 2) // switch (i - 2)
             *  10. create a case for this nested switch with case as 3: //case 3:
             *  11. display the value as 3 in console
             *  12. use break; statement at required sections
             *  13. to the main switch statement ceate a case with value as 10, another case 15 (inside each 
             *      of the case display the value in console)
             *  14. have a default case also    
             */

            //Code Here
            //...
        }

        public void PrintTheValueOfIInfiniteTimes()
        {
            //i = 1
            //Output: 1 1 1 1 1 1 1 1 1 .....

            //using for loop achieve the above output
        }

        public void ForLoopAndBreakStatement()
        {
            //declare a variable i
            //initialize the value to 0 for i (i = 0)
            //condition to check (i < 10) do a condition check (execute till this is true)
            //  until the value of i is less than 10 the for loop should run
            //inremented in steps of 1 i++ or i = i + 1

            //inside for loop do a condition check if value of i == 5
            //exit from for loop (break;)
            //if (i == 5)
            //   { 
            //      break; 
            //   }

            //print the output in console: i

            //Output: 
            /* 0
             * 1
             * 2
             * 3
             * 4
             */
        }

        public void UsingNestedWhileLoop()
        {
            /* Out required:
             * -------------
             * value of i: 0
             * value of j: 1
             * value of i: 1
             * value of j: 1
             */

            //create a variable i and initialize to 0
            //while (i < 2)
            //Console.WriteLine("Value of i: {0}", i);   (inside the while loop - i)
            //create a variable j and initialize to 1    (inside the while loop - i)
            //increment the value of i (i++)
            //  while (j < 2)                            (this while loop (j) is inside the while loop (i)) - nesting of while loop   
            //  Console.WriteLine("Value of j: {0}", j); (inside the while loop - j)
            //  increment the value of i (j++)           (inside the while loop - j)

        }

        public void UsingNestedDoWhileLoop()
        {
            /* Out required:
             * -------------
             * value of i: 0
             * value of j: 0
             * value of j: 1
             * value of i: 1
             * value of j: 1
             */

            //create a variable i and initialize to 0
            //do 
            //Console.WriteLine("Value of i: {0}", i);   (inside the do..while loop - i)
            //int j = i; -- 0 | 1
            //i++  -- 1 | 2
            //(nesting of our do..while loop)
            //  do
            //  Console.WriteLine("Value of j: {0}", j); (inside the do..while loop - j)
            //  j++ 
            //  while (j<2) -- (1<2) | (2<2)
            //while (i<2) -- (1<2) | (2<2)
        }

        public void UsingFiles()
        {
            /*
             * Bank.info
             * 
             Bank
                01. Name:
                02. Address:
                03. Type Account: Saving / Current
                04. Account Number: <16 digit number>
                05. Balance: 
                06. Open Date:

                Name: Jack
                Address: 145, Friends Apartment, East Avenue, Chennai, TamilNadu, India - 600100
                Type Account: Saving10 Customer
                Account Number: 1234567890123456
                Balance: 5,800.42
                Name: Sara
                Address: 146, Friends Apartment, East Avenue, Chennai, TamilNadu, India - 600100
                Type Account: Current
                Account Number: 1234567890123456
                Balance: 5,800.42
                Open Date: 20-Mar-2019
            
                Enter the name of the customer to search: Sara
                
             */
        }
    }
}