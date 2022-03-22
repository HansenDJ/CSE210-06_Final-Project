namespace generalNamespace;
using Raylib_cs;

using static Raylib_cs.Raylib;
public class Character
{
    public int x;
    public int y;
    // Width offset for collider box
    public int offsetWidth = 10;
    // Height offset for collider box
    public int offsetHeight = 30;

    public Image charImage;
    public Texture2D charTexture;
    
    public void SetX(int characterX)
    {
        x = characterX;
    }

    public void SetY(int characterY)
    {
        y = characterY;
    }

    public void SetImage(Image image)
    {
        charImage = image;
        charTexture = LoadTextureFromImage(image);
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