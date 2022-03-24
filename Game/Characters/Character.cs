using Raylib_cs;
using static Raylib_cs.Raylib;

namespace generalNamespace;

public class Character
{
    public int x;
    public int y;
    // Width offset for collider box
    public int offsetColliderWidth = 10;
    // Height offset for collider box
    public int offsetColliderHeight = 30;
    public int colliderBoxWidth = 0;
    public int colliderBoxHeight = 0;
    // Width and height offsets for collider box from character image file
    public int offsetW = 0;
    public int offsetH = 0;

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

    public void SetOffsetColliderWidth(int offsetWidth)
    {
        offsetColliderWidth = offsetWidth;
    }
    public int GetOffsetColliderWidth()
    {
        return offsetColliderWidth;
    }
    public void SetOffsetColliderHeight(int offsetHeight)
    {
        offsetColliderHeight = offsetHeight;
    }
    public int GetOffsetColliderHeight()
    {
        return offsetColliderHeight;
    }
    // Return the width and height of the character collider box
    public int GetColliderBoxWidth()
    {
        return GetImageWidth() - offsetColliderWidth;
    }
    public int GetColliderBoxHeight()
    {
        return GetImageHeight() - offsetColliderHeight;
    }

    public void SetTexture(Image image)
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