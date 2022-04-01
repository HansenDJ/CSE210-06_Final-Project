using Raylib_cs;

namespace CSE210_06_Final_Project;


public static class loadScreenVisual
{

    public static Image charImage;
    public static Texture2D charTexture;
   public static void loadScreen()
    {
        Raylib.BeginDrawing();
        SetTexture(SetSpaceBGStartImage());
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawTexture(charTexture,0,0,Color.WHITE);
        Raylib.DrawText("In the year 2355 a great war occured in the Galactic Empire\n" +
                         "You were gambling in a casino and your opponent had a Royal Flush." +
                         "\nIn order to pay off your debt and maintain freedom you must "+
                         "\ndestroy enemies and collect enough coins. If you fail to obtain the " +
                         "\nrequired amount of coins you will be sold as a slave to work in the galactic mines." +
                         "\nPush the Spacebar to begin your journey.",270,270,25,Color.WHITE);
        

        Raylib.EndDrawing();
    }
    public static void SetTexture(Image image)
    {
        charImage = image;
        charTexture = Raylib.LoadTextureFromImage(image);
    }

    public static Image SetSpaceBGStartImage()
    {
        // Load Back Gound for Earth level
        return Raylib.LoadImage("Game/Images/bg/spacebg.png");
    }
}