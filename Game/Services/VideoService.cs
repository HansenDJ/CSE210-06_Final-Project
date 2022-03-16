using System;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
namespace generalNamespace;
public class VideoService
{
    int scrnWidth = 1000;
    int scrnHeight = 1000;

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


}