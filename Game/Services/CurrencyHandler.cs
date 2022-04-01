namespace generalNamespace;

public static class CurrencyHandler
{
    public static int money = 0;

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
        else

            return false;
    }

    public static int CheckMoney()
    {
        if (money < 100)
        {
            return 1;
        }

        else if (money >= 100 && money < 200)
        {
            return 2;
        }
        else if (money >= 200 && money < 300)
        {
            return 3;
        }
        else if (money >= 300)
        {
            return 4;
        }
        else
        {
            Console.WriteLine("ERROR:Money is negative!");
            return 5;
        }
    }
}
