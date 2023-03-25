using System;

class Orc
{
    private static int totalGold = 0;
    private static int orcCount = 0;

    public int Gold { get; private set; }

    public Orc()
    {
        Gold = 0;
        orcCount++;
        totalGold += 2;
        if (orcCount > 5)
        {
            totalGold -= 2;
            Gold = 2;
        }
    }

    public static int TotalGold()
    {
        return totalGold;
    }
}
