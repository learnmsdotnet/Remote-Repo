class Constant
{
    public readonly int ID;
    private int value;
    public const int HEIGHT = 108;

    public Constant()
    {
        ID = 3;
        System.Console.WriteLine(ID);
        System.Console.WriteLine(HEIGHT);
    }

    public Constant(int value)
    {
        ID = 4;        
        this.value = value;
        System.Console.WriteLine(ID);
        System.Console.WriteLine(HEIGHT);
    }
}

