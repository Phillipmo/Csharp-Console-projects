while (true)
{
    Console.WriteLine("Velkommen til ConCalc");
    Console.WriteLine("---------------------");
    Console.WriteLine("1. Plus");
    Console.WriteLine("2. Træk fra");
    Console.WriteLine("3. Gange");
    Console.WriteLine("4. Dividere");
    Console.WriteLine("5. bruttoløn");
    Console.WriteLine("6. køreselsfradrag");
    Console.WriteLine("---------------------");
    Console.Write("Vælg funktion: ");
    string funktion = Console.ReadLine();
    Console.Write("Tal 1: ");
    string tal1 = Console.ReadLine();
    Console.Write("Tal 2: ");
    string tal2 = Console.ReadLine();
    double resultat = 0;

    if (funktion == "1")
    {
        resultat = Convert.ToDouble(tal1) + Convert.ToDouble(tal2);
    }
    else if (funktion == "2")
    {
        resultat = Convert.ToDouble(tal1) - Convert.ToDouble(tal2);
    }
    else if (funktion == "3")
    {
        resultat = Convert.ToDouble(tal1) * Convert.ToDouble(tal2);
    }
    else if (funktion == "4")
    {
        resultat = Convert.ToDouble(tal1) / Convert.ToDouble(tal2);
    }
    else if (funktion == "5")
    {
        double bruttoløn = readdouble("Indtast bruttoløn: ");
        double månedsfordrag = readdouble("Indtast månedsfordrag: ");
        double trakprocent = readdouble("Indtast trakprocent: ");
        Console.WriteLine(bruttoløn - ((bruttoløn - månedsfordrag) / 100 ) * trakprocent);
    }
    else if (funktion == "6")
    {
        double dage = readdouble("Indtast dage: ");
        double km = readdouble("Indtast km: ");
        Console.WriteLine(dage * (km * 2));
    }
    Console.WriteLine("---------------------");
    Console.Write("Resultat: ");
    Console.WriteLine(resultat);
    Console.WriteLine("---------------------");
    Console.ReadLine();
    Console.Clear();
    
    
}
static double readdouble(string promt)
{
    Console.Write(promt);
    string input = Console.ReadLine();
    double value = Convert.ToDouble(input);
    return value;
}