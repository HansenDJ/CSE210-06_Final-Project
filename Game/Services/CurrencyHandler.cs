namespace generalNamespace;

public static class CurrencyHandler
{
    private static int money = 0;

    public static int GetMoneyAmount()
    {
        return money;
    }

    public static void AddOne()
    {
        money += 1;
    }
    public static void AddFive()
    {
        money += 5;
    }
    public static void AddTen()
    {
        money += 10;
    }
    public static void AddTwenty()
    {
        money += 20;
    }
    public static void AddFiftey()
    {
        money += 50;
    }
    public static void AddOneHundred()
    {
        money += 100;
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
       
    }
    
    
