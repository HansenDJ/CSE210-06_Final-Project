using System;
using generalNamespace.Laser;

namespace generalNamespace;

public class Player : Character
{
    // Player constants
    public static int playerMovementSpeed = 0;
    public static int playerHealth = 0;
    private int offsetW = 10;
    private int offsetH = 30;
   
    

    // SETS player constants
    public void SetPlayerStats()
    {
        playerMovementSpeed = 1;    // Set default in the director
        playerHealth = 100;     // Set default in the director
        SetOffsetColliderWidth(offsetW);    // Width offset for player collider box
        SetOffsetColliderHeight(offsetH);   // Height offset for player collider box
    }

   
    
    public int PlayerMoveKeys()
    {
      
        
        // Up movement with W key or up arrow key
        if (KeyboardService.WKeyDown() || KeyboardService.UpKeyDown())
        {
            
            if (y >= 0)
            {
                y -= playerMovementSpeed;  
            }
        // Down movement with S key or down arrow key
        }else if (KeyboardService.SKeyDown() || KeyboardService.DownKeyDown())
        {
           
            if (y <= VideoService.scrnHeight - GetColliderBoxHeight() * 2)
            {
               y += playerMovementSpeed;
            }
                 
        }

        // Left movement with A key or left arrow key
        if ((KeyboardService.AKeyDown() || KeyboardService.LeftKeyDown()) && x >= offsetColliderWidth)
        {
          
            if(x > 10) {}
            x -= playerMovementSpeed;
        // Right movement with D key or right arrow key
        }else if ((KeyboardService.DKeyDown() || KeyboardService.RightKeyDown()) && x < VideoService.scrnWidth / 2 - GetOffsetColliderWidth())
        {
          
            x += playerMovementSpeed;
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
