using Raylib_cs;

namespace CSE210_06_Final_Project;


public static class OutOfDedt
{

    public static Image charImage;
    public static Texture2D charTexture;
   public static void loadScreen()
    {
        Raylib.BeginDrawing();
        SetTexture(SetSpaceBGStartImage());
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawTexture(charTexture,0,0,Color.WHITE);
        Raylib.DrawText("You payed off your debt",210,270,75,Color.WHITE);
        Raylib.DrawText("Push the [Spacebar] to Contiune your journey.",370,490,25,Color.WHITE);

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