using System;
class Program
{
    static void Main()
    {
        Orc orc1 = new Orc();
        Orc orc2 = new Orc();
        Orc orc3 = new Orc();
        Orc orc4 = new Orc();
        Orc orc5 = new Orc();
        Orc orc6 = new Orc();

        Console.WriteLine("Total gold: " + Orc.TotalGold());
    }
}