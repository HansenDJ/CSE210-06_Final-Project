using Raylib_cs;

namespace CSE210_06_Final_Project;


public static class loadScreenVisual
{
   public static void loadScreen()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawText("In the year 2055 a great war occured in the Galactic Empire\n" +
                        "You were gambling in a casino and your opponent has a Royal Flush." +
                        "\n In order to maintain freedom you must destroy enemies and collect" +
                        "\nenough coins. If you fail to obtain the required amount of coins " +
                        "\nyou will be sold as a slave to work in the galactic mines.",250,250,25,Color.WHITE);
        Raylib.EndDrawing();
    }
}