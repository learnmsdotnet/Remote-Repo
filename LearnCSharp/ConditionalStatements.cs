using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class ConditionalStatements
    {
        public string IfStmtEvaluation()
        {
            if (true)
            {
                return "the expression is evaluated to be true and the code block inside if.. stmt is execuited";
            }

            if (false)
            {
                return "the expression is evaluated to be false and the code block inside if.. stmt will never be execuited";
            }
        }

        public void IfElseStmtEvaluation()
        {
            //if the value is even call the class MyClass and if the value is odd call the class AnotherClass
            int iCount = 4;
            if ((iCount % 2) == 0)
            {
                //express is evaluated to be true
                MyClass objMyClass = new MyClass();
                //code continues ...
            }
            else
            {
                //express is evaluated to be false
                AnotherClass objAnotherClass = new AnotherClass();
                //code continues ...
            }
        }

        public void IfElseNestingStatements()
        {
            //Ctrl K + C -- Selected code block will be commented
            //Ctrl K + U -- Selected code block will be uncommented

            int iDataA = 10, iDataB = 20;

            if (iDataA > iDataB)
            {
                Console.WriteLine("a is greater than b");
                //more lines of code to follow, use the { .. }
            }
            else if (iDataA < iDataB)
            {
                Console.WriteLine("a is less than b");
            }
            else
            {
                Console.WriteLine("a is equal to b");
            }

            if (iDataA > iDataB)
                Console.WriteLine("A is greater than B");            
            else if (iDataA < iDataB)
                Console.WriteLine("A is less than B");
            else
                Console.WriteLine("A is equal to B");

            //Logic: Check if the value of variable is greater than 0 then proceed further  (check initial condition satisfies or not)
            //          then check if the value is greater than equal 100                   (second condition check)
            //          with output print in console if it is greater than 100 or not       (based on second condition we show the output)

            Int16 iDataE = 10;
            if (iDataE > 0)
            {
                //if the value is greater than 0 (condition is satisfied)
                if (iDataE <= 100)
                {
                    Console.WriteLine("the value of the variable is less that or equal to 100");
                }
                else
                {
                    Console.WriteLine("the value of the variable is greater than 100");
                }
            }
        }

        /// <summary>
        /// Understanding ternary operator in C#
        /// </summary>
        public void TernaryOperator()
        {
            //Logic: Out of the two variable we need to check which is greater
            Int16 iDataF = 10, iDataG = 20;

            string result = (iDataF > iDataG) ? "Variable F is greater than G" : "Variable F is less than G";
            Console.WriteLine(result);
        }

        /// <summary>
        /// Another example of Ternary Operator
        /// </summary>
        public void TernaryOperatorEg2()
        {
            //Comparing 2 int variables and returning the biggest variable
            Int16 iDataA = 20, iDataB = 10;

            Int16 result = (iDataA > iDataB) ? iDataA : iDataB;

            Console.WriteLine(result);
        }

        /// <summary>
        /// Understanding switch statement
        /// </summary>
        public void SwitchStatement()
        {
            //Logic: a value is assigned for a variable, if it matches with any condition execuite the code block inside them
            //  if no match is identified then default should be execuited

            int iDataA = 10;

            switch (iDataA) //10
            {
                case 5: //<-- case if (10 == 5) (One case block is mandatory)
                    Console.WriteLine("the value of A is: 5");
                    break;
                case 10: //<-- case if (10 == 10)
                    Console.WriteLine("the value of A is: 10");
                    break;
                case 15:
                    { 
                        //brackets need to used for multiple statement inside case
                        Console.WriteLine("the value of A is: 15");
                    }
                    break;
                case 20:
                    Console.WriteLine("the value of A is: 20");
                    break;
                default: //(default case is optional)
                    Console.WriteLine("unknown value - could not find the value of A");
                    break;
            }
        }

        /// <summary>
        /// Using goto in switch case statement
        /// </summary>
        public void GoToInSwitchStatement()
        {
            string statement = "switch";

            switch (statement) //switch
            {
                case "DecisionMaking":
                    Console.WriteLine("Code block of DecisionMaking statement");
                    break;
                case "if.else":
                    Console.WriteLine("Code block of if.else statement");
                    break;
                case "ternary":
                    Console.WriteLine("Code block of ternary statement");
                    break;
                case "switch":
                    Console.WriteLine("Code block of switch statement");
                    goto case "DecisionMaking";
            }
        }
    }
}
