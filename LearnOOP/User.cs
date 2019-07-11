class User
{
    private string username;
    private int password;

    public string UserName
    {
        get
        {
            return username;
        }
        set
        {
            //Condition 1
            //Assign user name only if the username length is between 4 and 10 char
            if (value.Length > 4 && value.Length < 10)
            {
                username = value;
            }
            else
            {
                //cw (tab) (tab)
                System.Console.WriteLine("Oops, this is not a valid user name !");                                
            }            
        }
    }

    public int Password
    {
        get
        {
            return password;
        }
        set
        {
            if (value > 4 && value < 10)
            { 
                password = value;
            }
            else
            {
                System.Console.WriteLine("Oops, this is not a valid password, Please use password with 4 to 10 chars length");
            }
        }
    }

}

