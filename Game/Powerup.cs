using System.Reflection;

namespace generalNamespace;

public static class Powerup
{
    public static double effectTime = 0;
    public static double endTime = 0;
    public static bool isExplosiveShot = false;
    public static bool isShielded = false;
    

    public static void SetEffectTime(double time)
    {
        effectTime = time;
    }

    public static void ReduceEffectTime()
    {
        effectTime = endTime - Director.secondsPassed;
        if (effectTime <= 0)
        {
            isExplosiveShot = false;
            isShielded = false;
        }
    }

    public static void randomEffect()
    {
        Random rnd = new Random();
        int decision = rnd.Next(1, 7);
        switch (decision)
        {
            case 1: 
                PlayerStats.playerHealth -= 50;
                break;
            case 2: PlayerStats.playerHealth -= 25;
                break;
            case 3:
                PlayerStats.playerHealth = PlayerStats.maxPlayerHealth;
                break;
            case 4:
                
                isExplosiveShot = true;
                isShielded = false;
                effectTime = rnd.Next(5, 20);
                endTime = Director.secondsPassed + effectTime;
                
                
                break;
            case 5: 
                isShielded = true;
                isExplosiveShot = false;
                effectTime = rnd.Next(5, 20);
                endTime = Director.secondsPassed + effectTime;
                
                break;
            case 6:
                CurrencyHandler.money += 300;
                break;

        }
        {
            
        }
    }
}