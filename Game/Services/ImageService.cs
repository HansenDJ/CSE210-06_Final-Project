using System;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace generalNamespace;

public class ImageService
{
    // Create methods to define in the RaylibImageService class to load the image files into textures.
    public static Texture2D SetShipImage() {
        // Load ship image
        Image image = LoadImage("Game/Images/ship/ship1.png");
        Texture2D shipTexture = LoadTextureFromImage(image);
        return shipTexture;
    }
}