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
        if (money < 220) return 1;

        if (money >= 220 && money < 550) return 2;

        if (money >= 550 && money < 1000) return 3;

        if (money >= 1000)
        {
            return 4;
        }

        Console.WriteLine("ERROR:Money is negative!");
        return 5;
    }
}