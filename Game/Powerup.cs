using System.Reflection;

namespace generalNamespace;

public static class Powerup
{
    public static double effectTime = 0;
    public static double endTime = 0;
    public static bool isExplosiveShot = false;
    public static bool isShielded = false;

    public static bool isRestoredHealth = false;

    public static bool isHealthHit1 = false;

    public static bool isHealthHit2 = false;

    public static bool isCoins = false;
    

    public static void SetEffectTime(double time)
    {
        effectTime = time;
    }

    public static void ReduceEffectTime(Player player)
    {
        effectTime = endTime - Director.secondsPassed;
        if (effectTime <= 0)
        {
            isHealthHit1 = false;
            isHealthHit2 = false;
            isRestoredHealth = false;
            isExplosiveShot = false;
            isShielded = false;
            isCoins = false;
            player.offsetW = 18;
            player.offsetH = 14;
            player.SetOffsetColliderWidth(player.offsetW);
            player.SetOffsetColliderHeight(player.offsetH);
        }
    }
    public static void IsHealthHit2Effect()
    {
        PlayerStats.playerHealth -= 50;
        isHealthHit1 = false;
        isHealthHit2 = true;
        isRestoredHealth = false;
        isExplosiveShot = false;
        isShielded = false;
        isCoins = false;
        effectTime = 3;
        endTime = Director.secondsPassed + effectTime;
        AudioService.PlayAudio(AudioService.hurtPlayer);
    }
    public static void IsHealthHit1Effect()
    {
        PlayerStats.playerHealth -= 25;
        isHealthHit1 = true;
        isHealthHit2 = false;
        isRestoredHealth = false;
        isExplosiveShot = false;
        isShielded = false;
        isCoins = false;
        effectTime = 3;
        endTime = Director.secondsPassed + effectTime;
        AudioService.PlayAudio(AudioService.hurtPlayer);
    }
    public static void IsExplosiveEffect()
    {
        Random rnd = new Random();
        isHealthHit1 = false;
        isHealthHit2 = false;
        isRestoredHealth = false;
        isExplosiveShot = true;
        isShielded = false;
        isCoins = false;
        effectTime = rnd.Next(5, 20);
        endTime = Director.secondsPassed + effectTime;
    }

    public static void IsShieldedEffect()
    {
        Random rnd = new Random();
        isHealthHit1 = false;
        isHealthHit2 = false;
        isRestoredHealth = false;
        isExplosiveShot = false;
        isShielded = true;
        isCoins = false;
        effectTime = rnd.Next(5, 20);
        endTime = Director.secondsPassed + effectTime;
    }


    public static void IsRestoredHealthEffect()
    {
        PlayerStats.playerHealth = PlayerStats.maxPlayerHealth;
        isHealthHit1 = false;
        isHealthHit2 = false;
        isRestoredHealth = true;
        isExplosiveShot = false;
        isShielded = false;
        isCoins = false;
        effectTime = 3;
        endTime = Director.secondsPassed + effectTime;
    }
    public static void IsCoinsEffect()
    {
        CurrencyHandler.money += 300;
        isHealthHit1 = false;
        isHealthHit2 = false;
        isRestoredHealth = false;
        isExplosiveShot = false;
        isShielded = false;
        isCoins = true;
        effectTime = 3;
        endTime = Director.secondsPassed + effectTime;
    }
    public static void randomEffect()
    {
        Random rnd = new Random();
        int decision = rnd.Next(1, 7);
        switch (decision)
        {
            case 1: 
                IsHealthHit1Effect();
                break;
            case 2: 
                IsHealthHit2Effect();
                break;
            case 3:
                IsRestoredHealthEffect();
                break;
            case 4:
                IsExplosiveEffect();
                break;
            case 5:
                IsShieldedEffect();
                break;
            case 6:
                IsCoinsEffect();
                break;

        }
        {
            
        }
    }
}