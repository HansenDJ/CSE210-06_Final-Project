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
        if (money < 100) return 1;

        if (money >= 100 && money < 500) return 2;

        if (money >= 500 && money < 1000) return 3;

        if (money >= 1000 && money < 1500) return 4;

        if (money >= 1500 && money < 2000) return 5;

        if (money >= 2500 && money < 3000) return 6;

        if (money >= 3000 && money < 3500) return 7;

        if (money >= 3500 && money < 5000) return 8;

        if (money >= 5000 && money < 10000)
        {
            return 9;
        }
        if (money >= 10000)
        {
            return 10;
        }

        Console.WriteLine("ERROR:Money is negative!");
        return 11;
    }
}