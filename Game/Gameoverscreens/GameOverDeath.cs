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
        //AudioService.LoadAudio(AudioService.GameOverSound);
        Raylib.BeginDrawing();
        SetTexture(SetSpaceBGStartImage());
        //AudioService.PlayAudio(AudioService.GameOverSound);
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawTexture(charTexture, 0, 0, Color.WHITE);
        Raylib.DrawText("Game Over", 440, 270, 100, Color.WHITE);
        Raylib.DrawText("You took too much damage and died.", 470, 400, 25, Color.WHITE);
        Raylib.EndDrawing();
        //AudioService.UnloadAudio(AudioService.GameOverSound);
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