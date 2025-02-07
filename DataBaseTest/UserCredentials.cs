class UserCredentials
{
    private string name, password;
    static private UserCredentials user = new UserCredentials("username", "password");

    static public string Name
    {
        get { return user.name; }
    }

    static public string Password
    {
        get { return user.password; }
    }

    private UserCredentials(string name, string password)
    {
        this.name = name;
        this.password = password;
    }
}