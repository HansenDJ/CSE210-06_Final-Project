using System;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace generalNamespace;

public class ImageService
{
    
    // Create methods to define in the RaylibImageService class to load the image files into textures.
    
    public static Image SetShipStartImage() {
        // Load ship image
        return LoadImage("Game/Images/ship/startship.png");
    }
    
}