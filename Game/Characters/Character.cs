using Raylib_cs;

namespace generalNamespace;

public class Character
{
    // public Image charImage;
    public Texture2D charTexture;
    public int colliderBoxHeight = 0;

    public int colliderBoxWidth = 0;

    // Width offset for collider box
    public int offsetColliderWidth = 0;
    // Height offset for collider box
    public int offsetColliderHeight = 0;

    public int offsetH = 0;

    // Width and height offsets for collider box from image file
    public int offsetW = 0;
    public int x;
    public int y;

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
        return GetTextureWidth() - offsetColliderWidth;
    }

    public int GetColliderBoxHeight()
    {
        return GetTextureHeight() - offsetColliderHeight;
    }

    // public Texture2D SetTexture(Image image)
    // {
    //     charImage = image;
    //     charTexture = LoadTextureFromImage(charImage);
    //     // UnloadImage(charImage);
    //     return charTexture;
    // }

    public void SetCharTexture(Texture2D characterTexture)
    {
        charTexture = characterTexture;
    }

    public Texture2D GetCharTexture()
    {
        return charTexture;
    }

    // Returns the width of the image file
    public int GetTextureWidth()
    {
        return charTexture.width;
    }

    // Returns the height of the image file
    public int GetTextureHeight()
    {
        return charTexture.height;
    }
}