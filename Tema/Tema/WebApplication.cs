namespace Tema;
public class WebApplication : Application
{
    protected List<string> _list = new List<string>();

    public WebApplication(string name) : base(name)
    {
    }
    
    public void Add(string name)
    {
        _list.Add(name);
    }

    public void Delete(string name)
    {
        _list.Remove(name);
    }
    
    public string HttpRequest(User user)
    {
        if (_list.Contains(user.getName()))
            return "Ok Request";
        return "Bad Request";
    }

    public int GetNumberOfUsers()
    {
        return _list.Count;
    }
    
    public string GetName()
    {
        return name;
    }
    
    public override string ToString()
    {
        return name + " - " + _list.Capacity;
    }
    
}