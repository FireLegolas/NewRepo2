Rozmowa:
while (true)
{
    Console.WriteLine("Wybierz rozmowe - wpisz 'IntelligentHuman' albo 'StupidHuman' albo wyjdź za pomoca 'Exit'");
    string osoba = Console.ReadLine();
    if (osoba == "IntelligentHuman")
    {
        goto WybórMądry;
    }
    else if (osoba == "StupidHuman")
    {
        goto WybórGłupi;
    }
    else if (osoba == "Exit")
        goto Koniec;
    else
    {
        Console.WriteLine("Zły wybór");
        continue;
    }
}
WybórMądry:
while (true)
{
    IntelligentHuman human = new IntelligentHuman();
    Console.WriteLine("Zadaj pytanie. Opcje: 'Godzina' albo 'Kalkulator' lub 'Exit' albo 'Back'");
    string pytanie = Console.ReadLine();
    if (pytanie == "Godzina")
    {
        Console.WriteLine(DateTime.Now.ToString());
        continue;
    }
    else if (pytanie == "Kalkulator")
    {
        Console.Write("Podaj pierwszą liczbę: ");
        var x = int.Parse(Console.ReadLine());
        Console.Write("Podaj drugą liczbę: ");
        var y = int.Parse(Console.ReadLine());
        Console.Write("Podaj operator z listy ('+', '-', '*', '/'): ");
        string z = Console.ReadLine();
        human.Kalk(x, y, z);
        continue;
    }
    else if (pytanie == "Exit")
        goto Koniec;
    else if (pytanie == "Back")
    {
        goto Rozmowa;
    }
    else
    {
        Console.WriteLine("Zły wybór");
    }
}
WybórGłupi:
while (true)
{
    StupidHuman human = new StupidHuman();
    Console.WriteLine("Zadaj pytanie. Opcje: 'Godzina' albo 'Kalkulator' lub 'Exit' albo 'Back'");
    string pytanie = Console.ReadLine();
    if (pytanie == "Godzina")
    {
        Console.WriteLine(DateTime.Now.ToString());
        continue;
    }
    else if (pytanie == "Kalkulator")
    {
        Console.Write("Podaj pierwszą liczbę: ");
        var x = int.Parse(Console.ReadLine());
        Console.Write("Podaj drugą liczbę: ");
        var y = int.Parse(Console.ReadLine());
        Console.Write("Podaj operator z listy ('+', '-', '*', '/'): ");
        string z = Console.ReadLine();
        human.Kalkulator(x, y, z);
        continue;
    }
    else if (pytanie == "Exit")
        break;
    else if (pytanie == "Back")
    {
        goto Rozmowa;
    }
    else
    {
        Console.WriteLine("Zły wybór");
    }
}
Koniec:
Console.WriteLine("Zamykanie programu");

Console.ReadKey();

abstract class Human
{
    int wynik;
    public void Kalk(int x, int y, string z)
    {
        switch (z)
        {
            case "+":
                wynik = x + y;
                break;
            case "-":
                wynik = x - y;
                break;
            case "*":
                wynik = x * y;
                break;
            case "/":
                wynik = x / y;
                break;
            default:
                throw new Exception("Wybrałeś złą operację!");
        }

        Console.WriteLine($"Twój wynik to: {wynik}");
    }
}

class StupidHuman : Human
{
    Random rnd = new Random();
    double a;
    public void Kalkulator(int x, int y, string z)
    {
        double a = rnd.Next(100);
        if (a > 69.5)
        {
            base.Kalk(x, y, z);
        }
        else
        {
            Console.WriteLine($"Twój błedny wynik to: {a}");
        }
    }
}

class IntelligentHuman : Human
{

}