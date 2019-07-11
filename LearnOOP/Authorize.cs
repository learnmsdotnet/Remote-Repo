class Authorize
{
    //read-only, write-only property
    
    private string username;
    private int password;

    //read-only property
    public string UserName
    {
        get { return username; }
    }

    //wite-only property
    public int Password
    {
        set { password = value; }
    }

    public Authorize(string username)
    {
        this.username = username;
    }
}

