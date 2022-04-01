using Raylib_cs;
using generalNamespace;

namespace CSE210_06_Final_Project;


public static class GameOverSoldAsSlave
{
   public static Image charImage;
   public static Texture2D charTexture;

   public static int soldAsSlave;

   public static string soldText;


   public static void loadScreen()
    {
        //AudioService.InitSound();
        //AudioService.LoadAudio(AudioService.loadscreen);
        Raylib.BeginDrawing();
        SetTexture(SetSpaceBGStartImage());
        Raylib.ClearBackground(Color.BLACK);
        Raylib.DrawTexture(charTexture,0,0,Color.WHITE);
        Raylib.DrawText("Game Over",440,270,100,Color.WHITE);
        Raylib.DrawText("You could pay your debts back....",490,400,25,Color.WHITE);
        Raylib.DrawText("You have been sold as a slave and will forever have to",360,430,25,Color.WHITE);
        Raylib.DrawText($"{soldText}",380,460,25,Color.WHITE);
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

    // Random rnd = new Random();

    // public static string SlaveLines(){
       
    //     soldAsSlave = rnd.Next(1,3);

    //     switch(soldAsSlave)
    //     {
    //         case 1:
    //             soldText = "click a button.";

    //         case 2:
    //             soldText = "clean the 73 bathrooms of your master's home.";
                
    //         case 3:
                
    //             soldText = "punch a tree.";  
                
    //     }

    // }
}