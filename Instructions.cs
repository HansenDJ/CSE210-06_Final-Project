using Raylib_cs;
using generalNamespace;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace CSE210_06_Final_Project;

public static class instructions
{
    public static void loadScreen()
    {
        Raylib.BeginDrawing();
        Raylib.DrawTexture(ImageService.spacebgTexture,0,0,Color.WHITE);
        Raylib.DrawText("Instructions", 460, 50, 75, Color.WHITE);
        Raylib.DrawText("Fire Weapons      =   [Spacebar] or [Enter]\n" +
                        "Move Up            =   [W] or [^]\n" +
                        "Move Backward   =   [A] or [<]\n" +
                        "Move Forward     =   [D] or [>]\n" +
                        "Move Down         =   [S] or [v]\n" +
                        "Gamble              =   [shift]\n" +
                        "Repair Ship        =   [Tab]", 440, 240, 25, Color.WHITE);

        Raylib.DrawText("Push the [R] key to begin your journey.", 455, 650, 25, Color.WHITE);
        Raylib.EndDrawing();
    }

}