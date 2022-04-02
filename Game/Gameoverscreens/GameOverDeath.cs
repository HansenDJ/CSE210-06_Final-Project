using Raylib_cs;
using generalNamespace;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace CSE210_06_Final_Project;

public static class GameOverDeath
{

    
    public static void loadScreen()
    {
        
      
        Raylib.BeginDrawing();
        
        Raylib.DrawTexture(ImageService.spacebgTexture,0,0,Color.WHITE);
        Raylib.DrawText("Game Over", 440, 270, 100, Color.WHITE);
        Raylib.DrawText("You took too much damage and died.", 470, 400, 25, Color.WHITE);
        Raylib.DrawText("Push the [R] key to begin your journey.", 469, 490, 25, Color.WHITE);
        Raylib.EndDrawing();
        // AudioService.UnloadAudio(AudioService.GameOverSound);
        // AudioService.CloseAudio();
    }

    


}