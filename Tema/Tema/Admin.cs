namespace Tema;
    
public class Admin 
{
    protected string name;
    protected List<string> _list = new List<string>();

    public Admin(string name, List<string> _list)
    {
        this.name = name;
        this._list = _list;
    }

    public void AddUser(User user, WebApplication app)
    {
        if(app.HttpRequest(user)=="Bad Request")
            app.Add(user.getName());
        else Console.WriteLine("Utilizatorul deja exista");
    }
    public void AddUser(User user, MobileApplication app)
    {
        if(app.HttpRequest(user)=="Bad Request")
            app.Add(user.getName());
        else Console.WriteLine("Utilizatorul deja exista");
    }

    public void RemoveUser(User user, WebApplication app)
    {
        if(app.HttpRequest(user)=="Ok Request")
            app.Delete(user.getName());
        else Console.WriteLine("Utilizatorul nu exista");
    }

    public void RemoveUser(User user, MobileApplication app)
    {
        if(app.HttpRequest(user)=="Ok Request")
            app.Delete(user.getName());
        else Console.WriteLine("Utilizatorul nu exista");
    }
}