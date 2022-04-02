namespace generalNamespace;

public static class PlayerStats
{
    public static int playerHealth = 150;

    public static int maxPlayerHealth = 150;

    public static bool PlayerDeadCheck()
    {
        if (playerHealth <= 0) return true;
        return false;
        // AudioService.DiedSound();
    }
}