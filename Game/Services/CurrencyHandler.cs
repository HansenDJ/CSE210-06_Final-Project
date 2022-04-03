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

        if (money >= 100 && money < 200) return 2;

        if (money >= 200 && money < 330) return 3;

        if (money >= 330 && money < 450) return 4;

        if (money >= 450 && money < 580) return 5;

        if (money >= 580 && money < 700) return 6;

        if (money >= 700 && money < 1500) return 7;

        if (money >= 1500 && money < 3000) return 8;

        if (money >= 3000)
        {
            return 9;
        }

        Console.WriteLine("ERROR:Money is negative!");
        return 10;
    }
}