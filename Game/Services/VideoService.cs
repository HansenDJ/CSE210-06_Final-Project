using System;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
namespace generalNamespace;

public class VideoService
{
    public static int scrnWidth = 1400;
    public static int scrnHeight = 900;

    public static void Draw()
    {
        DrawBackdrop();
        DrawEntities();
        DrawShip();
    }

    private static void DrawBackdrop()
    {
        Raylib.ClearBackground(Raylib_cs.Color.RED);
    }

    private static void DrawEntities()
    {
        
    }

    private static void DrawShip()
    {
        
    }

    public void DrawPlayer(Player player)
    {
        
       // DrawCircle(player.x,player.y,player.radius,WHITE);
        DrawTexture(LoadTextureFromImage(player.charImage), player.x, player.y, WHITE);
       // DrawRectangle(player.x,player.y,370,370,WHITE);
        
        

    }


}