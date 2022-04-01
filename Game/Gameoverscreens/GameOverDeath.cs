using Raylib_cs;
using generalNamespace;

namespace CSE210_06_Final_Project;


public static class GameOverDeath
{
   public static Image charImage;
    public static Texture2D charTexture;
   public static void loadScreen()
    {
        //AudioService.InitSound();
        //AudioService.LoadAudio(AudioService.loadscreen);
        Raylib.BeginDrawing();
        SetTexture(SetSpaceBGStartImage());
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawTexture(charTexture,0,0,Color.WHITE);
        Raylib.DrawText("You took too much damage and died",270,270,25,Color.WHITE);
        Raylib.EndDrawing();
        //AudioService.UnloadAudio(AudioService.loadscreen);
        //AudioService.CloseAudio();
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