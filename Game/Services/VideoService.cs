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
        Raylib.ClearBackground(Color.BLACK);
    }

    private static void DrawEntities()
    {
        
    }

    private static void DrawShip()
    {
        
    }

    public void DrawPlayer(Player player)
    {


    }


}