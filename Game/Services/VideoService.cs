using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
namespace generalNamespace;
public class VideoService
{
    int scrnWidth = 1000;
    int scrnHeight = 1000;

    public static void draw()
    {
        drawBackdrop();
        drawEntities();
        drawShip();
    }

    private static void drawBackdrop()
    {
        Raylib.ClearBackground(Color.BLACK);
    }

    private static void drawEntities()
    {
        
    }

    private static void drawShip()
    {
        
    }


}