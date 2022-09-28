// See https://aka.ms/new-console-template for more information
abstract class Worker
{
    public string Name;
    public string Position;
    public string Workday;
//  Конструктори
    public Worker(){}

    public Worker(string n)
    {
        Name = n;
    } 
//  Методи
    public void Call()
    {
        
    }
    public void WriteCode()
    {
        
    }
    public void Relax()
    {
        
    }

    abstract public void FillWorkDay();

}

class Developer : Worker
{
    public Developer(string name, string workday)
    {
        Position = "Developer";
        Name = name;
        Workday = workday;
    }

    public override void FillWorkDay()
    {
        WriteCode();
        Call();
        Relax();
        WriteCode();
    }
}

class Manager : Worker
{
    private Random rnd = new Random();
    
    public Manager(string name, string workday)
    {
        Position = "Manager";
        Name = name;
        Workday = workday;
    }

    public override void FillWorkDay()
    {
        for (int i = 0; i < rnd.Next(10); i++)
        {
            Call();
        }
        Relax();
        for(int i = 0; i < rnd.Next(5); i++)
        {
            Call();
        }
    }
}

class Team
{
    private string Name;
    private List<Worker> List = new List<Worker>();

    public Team(string Name)
    {
        this.Name = Name;
    }

    public void Add()
    {
        Console.WriteLine("Please enter a name:");
        string name = Console.ReadLine();
        Console.WriteLine("Please enter a position:");
        string position = Console.ReadLine();
        Console.WriteLine("Please enter a workday:");
        string workday = Console.ReadLine();
        if (position == "Developer")
            List.Add(new Developer(name, workday));
        else if(position == "Manager")
            List.Add(new Manager(name, workday));
    }

    public void Info()
    {
        Console.WriteLine(Name + ":");
        foreach (Worker W in List)
        {
            Console.WriteLine(W.Name);            
        }
    }

    public void Crew()
    {
        Console.WriteLine(Name);
        foreach (Worker W in List)
        {
            Console.WriteLine(W.Name + " - " + W.Position + " - " + W.Workday);            
        }
    }
    
}


class Program
{
    static void Main(string[] args)
    {
        int i = 5;
        
        Console.WriteLine("Please enter the name of team:");
        string name = Console.ReadLine();
        Team team = new Team(name);

        Console.WriteLine("Menu:");
        Console.WriteLine("1. Add the Worker");
        Console.WriteLine("2. Get basic info");
        Console.WriteLine("3. Get all crew info");
        Console.WriteLine("0. Stop the program");
        do
        {
            Console.WriteLine("Please write a number of command");
            i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    team.Add();
                    break;
                case 2:
                    team.Info();
                    break;
                case 3:
                    team.Crew();
                    break;
                case 0:
                    return;
                default:
                    Console.WriteLine("Error, please try again");
                    break;
            }
        } while (true);
    }
}
