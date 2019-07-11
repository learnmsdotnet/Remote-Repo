class Rectangle
{
    private int length;
    private int breadth;

    //Expanded way of writing property1
    public int Length
    {
        get
        {
            return length;
        }
        set
        {
            length = value;
        }
    }

    //Expanded way of writing property2
    //public int Length
    //{
    //    get { return length; }
    //    set { length = value; }
    //}

    //Simplified way of writing property
    public int Breadth { get; set; }

    public Rectangle(int length, int breadth)
    {
        
    }
}