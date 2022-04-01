using System;

namespace generalNamespace;

public static class PlayerStats
{
    public static int playerHealth = 50;

    public static int maxPlayerHealth = 50;

 public static bool PlayerDeadCheck()
    {
        if (playerHealth <= 0)
        {
            return true;
        }
        return false;
    }


}