namespace generalNamespace;

public class Player : Character
{
    // Player constants
    public static int playerMovementSpeed = 0;
    public static int playerHealth;
    public static int moveHandler;
    public static char moveDirection = 's';
    public static int moveIncrement;

    public static int moveHandlerL;
    public static int moveHandlerR;
    public static char moveDirectionlr = 's';
    public static int moveIncrementL;
    public static int moveIncrementR;
    private readonly int playerXRange = VideoService.scrnWidth - VideoService.scrnWidth / 5;
    public int offsetW = 18;
    public int offsetH = 14;


    // SETS player constants
    public void SetPlayerStats()
    {
        // playerMovementSpeed = 15;
        playerHealth = 100;
        SetOffsetColliderWidth(offsetW); // Width offset for player collider box
        SetOffsetColliderHeight(offsetH); // Height offset for player collider box
    }

    public void moveHandleUPDW(char direction)
    {
        if (direction == 'u')
        {
            if (moveDirection == 'u')
            {
                moveIncrement += 5;
                moveHandler = moveIncrement / 3;
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
                moveIncrement += 5;
                moveHandler = moveIncrement / 3;
            }
            else
            {
                moveHandler = 0;
                moveDirection = 'd';
                moveIncrement = 0;
            }
        }
    }

    private void MoveHandleLR(char direction)
    {
        if (direction == 'l')
        {
            if (moveDirectionlr == 'l')
            {
                moveIncrementL += 2;
                moveHandlerL = moveIncrementL / 2;
            }
            else
            {
                moveHandlerL = 0;
                moveDirectionlr = 'l';
                moveIncrementL = 0;
            }
        }
        else if (direction == 'r')
        {
            if (moveDirectionlr == 'r')
            {
                moveIncrementR += 2;
                moveHandlerR = moveIncrementR / 2;
            }
            else
            {
                moveHandlerR = 0;
                moveDirectionlr = 'r';
                moveIncrementR = 0;
            }
        }
    }


    public int PlayerMoveKeys()
    {
        if (KeyboardService.WKeyReleased() || KeyboardService.UpKeyReleased() || KeyboardService.SKeyReleased() ||
            KeyboardService.DownKeyReleased())
        {
            moveHandler = 0;
            moveIncrement = 0;
        }

        if (KeyboardService.AKeyReleased() || KeyboardService.LeftKeyReleased() || KeyboardService.RightKeyReleased() ||
            KeyboardService.DKeyReleased())
        {
            moveHandlerL = 0;
            moveHandlerR = 0;
            moveIncrementL = 0;
            moveIncrementR = 0;
        }

        // Up movement with W key or up arrow key
        if (KeyboardService.WKeyDown() || KeyboardService.UpKeyDown())
        {
            moveHandleUPDW('u');
            if (y >= 0) y -= moveHandler;
            // Down movement with S key or down arrow key
        }

        if (KeyboardService.SKeyDown() || KeyboardService.DownKeyDown())
        {
            moveHandleUPDW('d');
            if (y <= VideoService.scrnHeight - GetColliderBoxHeight() * 2) y += moveHandler;
        }

        // Left movement with A key or left arrow key
        if ((KeyboardService.AKeyDown() || KeyboardService.LeftKeyDown()) && x >= offsetColliderWidth)
        {
            MoveHandleLR('l');
            if (x > 10)
            {
            }

            x -= moveHandlerL;
            x -= moveHandlerR;
            // Right movement with D key or right arrow key
        }

        if ((KeyboardService.DKeyDown() || KeyboardService.RightKeyDown()) &&
            x < 850)
        {
            MoveHandleLR('r');
            x += moveHandlerL;
            x += moveHandlerR;
        }

        if (KeyboardService.SpaceKeyDown()) return 1;
        return 0;
    }

    // public int GetPlayerMovementSpeed()
    // {
    //     return playerMovementSpeed;
    // }
    // Set players starting x and y coordinates
    public void SetPlayerXY(Player player)
    {
        player.x = 50;
        player.y = VideoService.scrnHeight / 2;
    }
}