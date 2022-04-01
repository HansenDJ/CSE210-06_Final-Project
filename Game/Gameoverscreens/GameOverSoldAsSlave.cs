using Raylib_cs;
using generalNamespace;

namespace CSE210_06_Final_Project;


public class GameOverSoldAsSlave
{
   public Image charImage;
   public Texture2D charTexture;

   public int soldAsSlave;

   public string soldText;
    public void SlaveLines(){
       
        soldAsSlave = rnd.Next(1,3);

        switch(soldAsSlave)
        {
            case 1:
                soldText = "click a button.";
                break;
            case 2:
                soldText = "clean the 73 bathrooms of your master's home.";
                break;
            case 3:
                soldText = "punch a tree.";  
                break;
        }

    }

   public void loadScreen()
    {
        //AudioService.InitSound();
        //AudioService.LoadAudio(AudioService.loadscreen);
        Raylib.BeginDrawing();
        SlaveLines();
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
    public void SetTexture(Image image)
    {
        charImage = image;
        charTexture = Raylib.LoadTextureFromImage(image);
    }

    public Image SetSpaceBGStartImage()
    {
        // Load Back Gound for Earth level
        return Raylib.LoadImage("Game/Images/bg/spacebg.png");
    }

    Random rnd = new Random();

    
}