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

        if (money >= 80 && money < 150) return 2;

        if (money >= 150 && money < 330) return 3;

        if (money >= 330 && money < 400) return 4;

        if (money >= 400 && money < 520) return 5;

        if (money >= 520 && money < 600) return 6;

        if (money >= 600 && money < 1500) return 7;

        if (money >= 1500 && money < 3000) return 8;

        if (money >= 3000)
        {
            return 9;
        }

        Console.WriteLine("ERROR:Money is negative!");
        return 5;
    }
}