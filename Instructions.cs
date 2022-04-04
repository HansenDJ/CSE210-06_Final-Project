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
        Raylib.DrawText("Instructions", 470, 50, 75, Color.WHITE);
        Raylib.DrawText("Move Up\n" +
                        "Move Backward\n" +
                        "Move Forward\n" +
                        "Move Down\n" +
                        "Fire Weapons\n" +
                        "Repair Ship (-100 Coins)\n" +
                        "Gamble (-50 Coins)" , 340, 240, 25, Color.WHITE);
        Raylib.DrawText("=   [W] or [^]\n" +
                        "=   [A] or [<]\n" +
                        "=   [D] or [>]\n" +
                        "=   [S] or [v]\n" +
                        "=   [Mouse Left] or [Spacebar]  or [Enter]\n" +
                        "=   [Mouse Right] or [Tab] or [H]\n" +
                        "=   [Shift]\n" , 680, 240, 25, Color.WHITE);





        Raylib.DrawText("Push the [R] key to begin your journey.", 455, 650, 25, Color.WHITE);
        Raylib.EndDrawing();
    }

}