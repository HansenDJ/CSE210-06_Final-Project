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
       
    }
   
   
 
