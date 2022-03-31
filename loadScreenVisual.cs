using Raylib_cs;

namespace CSE210_06_Final_Project;


public static class loadScreenVisual
{
   public static void loadScreen()
    {
        Raylib.BeginDrawing();
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawText("In the year 2355 a great war occured in the Galactic Empire\n" +
                        "You were gambling in a casino and your opponent had a Royal Flush." +
                        "\n In order to pay off your debt and maintain freedom you must "+
                        "\ndestroy enemies and collect enough coins. If you fail to obtain the " +
                        "\nrequired amount of coins you will be sold as a slave to work in the galactic mines." +
                        "\nPush the Spacebar to begin your journey.",250,250,25,Color.WHITE);
        Raylib.EndDrawing();
    }
}