//Both the classes are in same physical file

//public class Point
//{
//    public int x;
//    public int y;
//}

using PointAndLines;

public class EntryPoint
{
    static void Main()
    {
        Point point = new Point();
        point.x = 5;
        point.y = 3;
            
        //Object initilization can be simplified as below
        //Point point = new Point
        //{
        //    x = 5,
        //    y = 3
        //};

        System.Console.WriteLine(point.x);
        System.Console.WriteLine(point.y);

        //Human Class (Creating an object of the Human class and assigning initial values to the class)
        Human human = new Human(80, 130);
        //Creating an object of Human class and default constructor works
        Human humanTwo = new Human();

        humanTwo.Height = 80;
        humanTwo.Weight = 130;

        System.Console.WriteLine(human.Height);
        System.Console.WriteLine(human.Weight);

        //Create object of User class
        User user = new User();
        user.UserName = "ab";       //Oops, this is not a valid user name !
        user.UserName = "abcde";

        user.Password = 2;          //Oops, this is not a valid password, Please use password value between with 4 to 10
        user.Password = 5;

        //Create object of Authorize class
        Authorize authorize = new Authorize("abcd");
        //we can read the username
        System.Console.WriteLine(authorize.UserName);
        //we can not read the password
        //System.Console.WriteLine(authorize.Password);
        
        Department department = new Department("ab");
        Department department2 = new Department();
        department2.UserName = "ab";

        Constant constant = new Constant();
        System.Console.WriteLine(constant.ID);

        Constant constant2 = new Constant(4);
        System.Console.WriteLine(constant2.ID);
    }        
}

//Copy the class Point to different Physical file (Point.cs)