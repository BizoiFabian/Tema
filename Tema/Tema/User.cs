namespace Tema;

public class User
{
    protected string username;
    protected string password;
    protected string email;

    public User(string username, string password, string email)
    {
        this.username = username;
        this.password = password;
        this.email = email;
    }
    
    public void ChangePassword(string password)
    {
        this.password = password;
    }

    public string getMail()
    {
        return email;
    }

    public string getName()
    {
        return username;
    }

    public override string ToString()
    {
        return username + " " + email;
    }
}