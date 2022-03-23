using System;
using generalNamespace.Laser;

namespace generalNamespace;

public class Player : Character
{
    // Player constants
    public static int playerMovementSpeed = 10;
    public static int playerHealth = 100;
    private int offsetW = 10;
    private int offsetH = 30;

    // SETS player constants
    public void SetPlayerStats()
    {
        playerMovementSpeed = 10;    // Set default in the director
        playerHealth = 100;     // Set default in the director
        SetOffsetColliderWidth(offsetW);    // Width offset for player collider box
        SetOffsetColliderHeight(offsetH);   // Height offset for player collider box
    }

    public int PlayerMoveKeys()
    {
        if (KeyboardService.WKeyDown() || KeyboardService.UpKeyDown())
        {
            if (y > 10)
            {
                y -= GetPlayerMovementSpeed();  
            }
                
        }else if (KeyboardService.SKeyDown() || KeyboardService.DownKeyDown())
        {
            if (y < VideoService.scrnHeight - 10)
            {
               y += GetPlayerMovementSpeed();
            }
                 
        }

        if (KeyboardService.AKeyDown() || KeyboardService.LeftKeyDown() && x >= offsetColliderWidth)
        {
            if(x > 10) {}
            x -= GetPlayerMovementSpeed();
        }else if (KeyboardService.DKeyDown() || KeyboardService.RightKeyDown() && x < VideoService.scrnWidth / 2)
        {
            x += GetPlayerMovementSpeed();
        }

        if (KeyboardService.SpaceKeyDown())
        {
            return 1;
        }

        return 0;
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
