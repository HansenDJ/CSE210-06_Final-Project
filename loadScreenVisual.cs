using Raylib_cs;
using generalNamespace;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace CSE210_06_Final_Project;

public static class loadScreenVisual
{
    public static bool instructionsPageOpen = false;
    public static void loadScreen()
    {
        Raylib.BeginDrawing();
        Raylib.DrawTexture(ImageService.spacebgTexture,0,0,Color.WHITE);
        Raylib.DrawText("In the year 2355 a great war occured in the Galactic Empire. You" +
                        "\nwere gambling in a casino and your opponent had a Royal Flush. In" +
                        "\norder to pay off your debt and maintain freedom you must destroy " +
                        "\nenemies and collect enough coins. If you fail to obtain the required" +
                        "\namount of coins, you will be sold as a slave to work in the galactic" +
                        "\nmines.", 290, 270, 25, Color.WHITE);
        Raylib.DrawText("Push the [R] key to begin your journey.", 410, 490, 25, Color.WHITE);
        Raylib.DrawText("Push the [I] key to learn how to fly.", 420, 525, 25, Color.WHITE);
        

        Raylib.EndDrawing();
    }

    

}