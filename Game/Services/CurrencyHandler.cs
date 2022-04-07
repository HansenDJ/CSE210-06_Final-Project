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

        else if (money >= 100 && money < 500) return 2;

        else if (money >= 500 && money < 1000) return 3;

        else if (money >= 1000 && money < 1500) return 4;

        else if (money >= 1500 && money < 2000) return 5;

        else if (money >= 2000 && money < 3000) return 6;

        else if (money >= 3000 && money < 5000) return 7;

        else if (money >= 5000 && money < 10000) return 8;

        else if (money >= 10000 && money < 15000) return 9;

        // Returns 10 if money >= 15000
        else return 10;
    }
}