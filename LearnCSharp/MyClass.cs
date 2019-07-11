using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnCSharp
{
    public class MyClass
    {
        //Decleration of a variable        
        public string Header = string.Empty;

        //ctor <tab> <tab> which will auto create constructor for the class
        //The type is: Parameterless Constructor
        //Name of the class will always match with the name of the constructor (MyClass)
        //they will not have a return type
        //Lines of code inside the constructor will be automatically called
        public MyClass()
        {
            Console.WriteLine("Called from Constructor of the class - 'MyClass'");
        }

        //We have creted a public method inside the class
        public void MyMethod(int parameter1, string parameter2)
        {
            count = 1;
        }

        //Inside class properties can be created
        //Types (2): a. Auto Implemented Property b. Default property

        //prop <tab> <tab>
        //Eg: of AutoImplemented Property
        public int MyProperty { get; set; }

        //Default Property
        private int count;
        public int Counter {
            get { return count; }
            set { count = value; }
        }

        //implementing additional logic to property
        private int _propVariable;
        public int PropVariable
        {
            get {
                //logic: to the value of the private class variable multiply 2 to it then give the output
                return _propVariable * 2;
            }

            set {
                //logic: Substract 2 from the input value and assign to the prop. variable
                int assignment = value - 2;
                _propVariable = assignment;
            }
        }

        //public int PropVariable { get; set; }

        //this is called auto implemented property
        //made available from version 3.0
        public string Car { get; set; }
        //private string _Car;

        //Properties can be defined with only get and only set
        //this property does not have setter
        private string markSheetGrade = "A grade";
        public string MarkSheetGrade
        {
            get { return markSheetGrade; }
        }

        //this property only has setter (value stored in the private variable 'collegeName' cannot be used outside the class
        //could be used only for internal processing
        private string collegeName;
        public string CollegeName
        {
            set { collegeName = value; }
        }

    }//scope of Class 'MyClass' ends here

  


}
