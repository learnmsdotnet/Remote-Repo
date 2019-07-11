class Department
{
    //id is the shared variable among the objects of the class
    public static int id;
    private string username;

    public string UserName
    {
        set
        {
            username = value;
        }
    }

    public Department()
    {
        id++;
        System.Console.WriteLine(id);
    }

    public Department(string username)
    {
        id++;
        this.username = username;
        System.Console.WriteLine(id);
    }
}
