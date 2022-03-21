using System;

namespace generalNamespace;

public class Player : Character
{
    // Player constants
    public static int playerMovementSpeed = 5;

    public int GetPlayerMovementSpeed()
    {
        return playerMovementSpeed;
    }
}
