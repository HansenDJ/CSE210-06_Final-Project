using System;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace generalNamespace;

public class ImageService
{
    // Create methods to define in the RaylibImageService class to load the image files into textures.
    public static void setImage() {
        // Load ship image
        Image image = LoadImage("Game/Images/ship/ship.png");
        Texture2D shipTexture = LoadTextureFromImage(image);
        UnloadImage(image);




    }

}