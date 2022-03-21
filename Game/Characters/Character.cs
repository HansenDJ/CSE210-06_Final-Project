namespace generalNamespace;
using Raylib_cs;
using static Raylib_cs.Raylib;
public class Character
{
    public int x = 30;
    public int y = 30;
    public int radius = 30;
    public Image charImage;
    public void setX(int X)
    {
        x = X;
    }

    public void setY(int Y)
    {
        y = Y;
    }

    public void setRadius(int Radius)
    {
        radius = Radius;
    }

    public void setTexture(Image im)
    {
        charImage = im;
    }

    public int getWidth()
    {
        return charImage.width;
    }

    public int getHeight()
    {
        return charImage.height;
    }
    
    
}