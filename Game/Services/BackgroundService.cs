using Raylib_cs;
using static Raylib_cs.Raylib;
namespace generalNamespace;

public class BackgroundService
{
    // private Image bg1Image;
    // private Image bg2Image;
    public Texture2D bg1Texture;
    public Texture2D bg2Texture;
    public static Texture2D previousBGTexture;
    public static Texture2D currentBGTexture;
    public int x1 = 0;
    public int x2 = 1920;
    public int y1 = 0;
    public int y2 = 0;

    public void Setbq1()
    {
        
    }

    public void Setbg2()
    {
        
    }

    public void ServeBackgrounds()
    {
        x1 -= 3;
        x2 -= 3;
        if (x2 <= 0)
        {
            x1 = 0;
            x2 = 1920;
        }
    }
    public void LoadBGTexture(Texture2D backgroundTexture)
    {
        bg1Texture = backgroundTexture;
        bg2Texture = backgroundTexture;
        // UnloadImage(imagebg);
        currentBGTexture = bg1Texture;
    }

   

}