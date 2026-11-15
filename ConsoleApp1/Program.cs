using ConsoleApp1;

internal class Program
{
    static void Main(string[] args)
    {
        int num = 20;
        string name;

        if(num == 20)
        {
            Console.WriteLine("The number is 20");
            Console.WriteLine("What is your name ? ");
            name = Console.ReadLine();
        }
        else
        {
            Console.WriteLine("It is not 20");
        }


        List<Humen> humen = new List<Humen>
        {
            new Humen("robin", 39, "Göteborg"),
            new Humen("Maseh", 26, "Mazar"),
            new Humen("Junior", 15, "Stokholme")
        };

        var adults = humen.Where(h => h.age >= 18);

        foreach(Humen h in adults)
        {
            Console.WriteLine(h.name);
        }

        var sorterad = humen.OrderBy(h => h.age);
        foreach(Humen h in sorterad)
        {
            Console.WriteLine($"{h.name} {h.age} {h.city}");
        }

        var namn = humen.Select(n => n.name);
        foreach(var h in namn)
        {
            Console.WriteLine(h);
        }

    }
}