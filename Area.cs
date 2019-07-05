public class Area
{
    public int a;
    public int b;
    public int c;

    public Area(int a, int b)
    {
        //a = a; //Warning: CS1717  Assignment made to same variable; did you mean to assign something else?	
        this.a = a;
        this.b = b;
        this.c = 5;//Suggestion: Name can be simplified and the potiential fix c = 5 rather than this.c = 5;
    }
}