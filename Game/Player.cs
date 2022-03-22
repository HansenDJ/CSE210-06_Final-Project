using System;

namespace generalNamespace;

public class Player : Character
{
    // Player constants
    public static int playerMovementSpeed = 10;
    public static int playerHealth = 100;

    // SETS player constants
    public void SetPlayerStats()
    {
        playerMovementSpeed = 10;    // Set default in the director
        playerHealth = 100;     // Set default in the director
    }
    
    public int GetPlayerMovementSpeed()
    {
        return playerMovementSpeed;
    }

    // Set players starting x and y coordinates
    public void SetPlayerXY(Player player)
    {
        player.x = 50;
        player.y = VideoService.scrnHeight / 2;
    }
}
