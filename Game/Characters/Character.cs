namespace generalNamespace;
using Raylib_cs;
using static Raylib_cs.Raylib;
public class Character
{
    public int x = 30;
    public int y = 30;
    public int radius = 30;
    public Image charImage;
    public void SetX(int X)
    {
        x = X;
    }

    public void SetY(int Y)
    {
        y = Y;
    }

    public void SetRadius(int Radius)
    {
        radius = Radius;
    }

    public void SetImage(Image image)
    {
        charImage = image;
    }

    // Returns the width of the image file
    public int GetImageWidth()
    {
        return charImage.width;
    }

    // Returns the height of the image file
    public int GetImageHeight()
    {
        return charImage.height;
    }
    
    
}