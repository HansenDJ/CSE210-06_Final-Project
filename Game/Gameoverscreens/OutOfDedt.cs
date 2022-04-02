using Raylib_cs;
using generalNamespace;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace CSE210_06_Final_Project;

public static class OutOfDedt
{
    public static void loadScreen()
    {
        Raylib.BeginDrawing();
        Raylib.DrawTexture(ImageService.spacebgTexture,0,0,Color.WHITE);
        Raylib.DrawText("You payed off your debt", 210, 270, 75, Color.WHITE);
        Raylib.DrawText("Push the [R] to continue your journey.", 435, 490, 25, Color.WHITE);
        Raylib.EndDrawing();
    }

}