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
        if (money < 50) return 1;

        if (money >= 50 && money < 150) return 2;

        if (money >= 150 && money < 300) return 3;

        if (money >= 300 && money < 380) return 4;

        if (money >= 380 && money < 490) return 5;

        if (money >= 490 && money < 550) return 6;

        if (money >= 550 && money < 1000) return 7;

        if (money >= 1000)
        {
            return 8;
        }

        Console.WriteLine("ERROR:Money is negative!");
        return 5;
    }
}