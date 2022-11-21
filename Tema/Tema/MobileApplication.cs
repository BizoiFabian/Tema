namespace Tema;

public class MobileApplication : Application
{
    protected List<string> _list = new List<string>();

    public MobileApplication(string name) : base(name)
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
    
    private double rating()
    {
        double n = Convert.ToInt32(Console.ReadLine());
        return n;
    }
    
    public double RateApp()
    {
        double s = 0;
        for (int i = 1; i < _list.Capacity; i++)
            s += rating();
        s /= (_list.Capacity-1);
        Console.WriteLine("Rating:");
        return s;
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
