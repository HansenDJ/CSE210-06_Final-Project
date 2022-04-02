namespace generalNamespace;

public static class CurrencyHandler
{
    public static int money = 0;
    public static int randomMoney = 0;

    public static int GetMoneyAmount()
    {
        return money;
    }

    public static bool payMoney(int cost)
    {
        if (money >= cost)
        {
            money -= cost;
            return true;
        }

        return false;
    }

    public static int CheckMoney()
    {
        if (money < 80) return 1;

        if (money >= 80 && money < 160) return 2;

        if (money >= 160 && money < 240) return 3;

        if (money >= 240 && money < 320) return 4;

        if (money >= 320 && money < 400) return 5;

        if (money >= 400 && money < 480) return 6;

        if (money >= 480 && money < 560) return 7;

        if (money >= 560)
        {
            return 8;
        }

        Console.WriteLine("ERROR:Money is negative!");
        return 5;
    }
}