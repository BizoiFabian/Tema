using Tema;

User persoana1=new User("Den","den","den@gmail.com");
User persoana2=new User("Andreea","and","andreea@gmail.com");
User persoana3=new User("Iva","123","iva@gmail.com");
User persoana4=new User("Matilda", "123", "matilda@gmail.com");
User persoana5=new User("Ana", "123", "ana@gmail.com");

WebApplication web_app = new WebApplication("WebApp1");
MobileApplication mobile_app = new MobileApplication("MobileApp1");

List<string> lista_aplicatii = new List<string>(2);

lista_aplicatii.Add(web_app.GetName());
lista_aplicatii.Add(mobile_app.GetName());

Admin admin = new Admin(Console.ReadLine(), lista_aplicatii);

admin.AddUser(persoana1,web_app);
admin.AddUser(persoana2,web_app);

admin.AddUser(persoana3,mobile_app);
admin.AddUser(persoana4,mobile_app);
admin.AddUser(persoana5,mobile_app);

Console.WriteLine();

Console.WriteLine("afisare useri in web_app:");
Console.WriteLine(web_app.GetNumberOfUsers());

Console.WriteLine("afisare useri in mobile_app:");
Console.WriteLine(mobile_app.GetNumberOfUsers());

Console.WriteLine();

Console.WriteLine("afisare useri:");

Console.WriteLine(persoana1.ToString());
Console.WriteLine(persoana2.ToString());
Console.WriteLine(persoana3.ToString());
Console.WriteLine(persoana4.ToString());
Console.WriteLine(persoana5.ToString());

Console.WriteLine();

Console.WriteLine("Afisare rating pentru aplicatia mobile");

Console.WriteLine(mobile_app.RateApp());

Console.WriteLine();
Console.WriteLine("Eliminari si adaugari in aplicatii");

admin.RemoveUser(persoana1,web_app);
admin.RemoveUser(persoana1,web_app);
admin.RemoveUser(persoana5,mobile_app);
admin.RemoveUser(persoana4,mobile_app);
admin.RemoveUser(persoana1,mobile_app);

Console.WriteLine(web_app.GetNumberOfUsers());
admin.AddUser(persoana5,web_app);
admin.AddUser(persoana1,mobile_app);
Console.WriteLine(web_app.GetNumberOfUsers());
Console.WriteLine(mobile_app.GetNumberOfUsers());