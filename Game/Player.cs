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
    public static int moveHandler = 0;
    public static char moveDirection = 's';
    public static int moveIncrement = 0;
    
    public static int moveHandlerlr = 0;
    public static char moveDirectionlr = 's';
    public static int moveIncrementlr = 0;
    

    // SETS player constants
    public void SetPlayerStats()
    {
        playerMovementSpeed = 5;    // Set default in the director
        playerHealth = 100;     // Set default in the director
        SetOffsetColliderWidth(offsetW);    // Width offset for player collider box
        SetOffsetColliderHeight(offsetH);   // Height offset for player collider box
    }

    public void moveHandleUPDW(char direction)
    {
        if (direction == 'u')
        {
            if (moveDirection == 'u')
            {
                moveIncrement += 1;
                moveHandler = moveIncrement / 10;
            }
            else
            {
                moveHandler = 0;
                moveDirection = 'u';
                moveIncrement = 0;
            }
        }
        else if (direction == 'd')
        {
            if (moveDirection == 'd')
            {
                moveIncrement += 1;
                moveHandler = moveIncrement / 10;
            }
            else
            {
                moveHandler = 0;
                moveDirection = 'd';
                moveIncrement = 0;
            }
        }
    }

    void MoveHandleLR(char direction)
    {
        if (direction == 'l')
        {
            if (moveDirectionlr == 'l')
            {
                moveIncrementlr += 1;
                moveHandlerlr = moveIncrementlr / 10;
            }
            else
            {
                moveHandlerlr = 0;
                moveDirectionlr = 'l';
                moveIncrementlr = 0;
            }  
        }else if (direction == 'r')
        {
            if (moveDirectionlr == 'r')
            {
                moveIncrementlr += 1;
                moveHandlerlr = moveIncrementlr / 10;
            }
            else
            {
                moveHandlerlr = 0;
                moveDirectionlr = 'r';
                moveIncrementlr = 0;
            }  
        }
    }
    
               
    
    public int PlayerMoveKeys()
    {
        if (KeyboardService.WKeyReleased() || KeyboardService.UpKeyReleased() || KeyboardService.SKeyReleased() || KeyboardService.DownKeyReleased())
        {
            moveHandler = 0;
            moveIncrement = 0;
        }
        if (KeyboardService.AKeyReleased() || KeyboardService.LeftKeyReleased() || KeyboardService.RightKeyReleased() || KeyboardService.DKeyReleased())
        {
            moveHandlerlr = 0;
            moveIncrementlr = 0;
        }
        
        // Up movement with W key or up arrow key
        if (KeyboardService.WKeyDown() || KeyboardService.UpKeyDown())
        {
            moveHandleUPDW('u');
            if (y >= 0)
            {
                y -= moveHandler;  
            }
        // Down movement with S key or down arrow key
        }else if (KeyboardService.SKeyDown() || KeyboardService.DownKeyDown())
        {
            moveHandleUPDW('d');
            if (y <= VideoService.scrnHeight - GetColliderBoxHeight() * 2)
            {
               y += moveHandler;
            }
                 
        }

        // Left movement with A key or left arrow key
        if ((KeyboardService.AKeyDown() || KeyboardService.LeftKeyDown()) && x >= offsetColliderWidth)
        {
            MoveHandleLR('l');
            if(x > 10) {}
            x -= moveHandlerlr;
        // Right movement with D key or right arrow key
        }else if ((KeyboardService.DKeyDown() || KeyboardService.RightKeyDown()) && x < VideoService.scrnWidth / 2 - GetOffsetColliderWidth())
        {
            MoveHandleLR('r');
            x += moveHandlerlr;
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
