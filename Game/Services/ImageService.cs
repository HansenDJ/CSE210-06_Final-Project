using System;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace generalNamespace;

public class ImageService
{

    // Create methods to define in the RaylibImageService class to load the image files into textures.

    public static Image SetShipStartImage()
    {
        // Load ship image
        return LoadImage("Game/Images/ship/startship.png");
    }

    public static Image SetEarthOneStartImage()
    {
        // Load ship image for Earth LV 1
        return LoadImage("Game/Images/ship/earthlv1.png");
    }

    public static Image SetEarthTwoStartImage()
    {
        // Load ship image for Earth LV 2
        return LoadImage("Game/Images/ship/earthlv2.png");
    }

    public static Image SetEarthThreeStartImage()
    {
        // Load ship image for Earth LV 3
        return LoadImage("Game/Images/ship/earthlv3.png");
    }

        public static Image SetEarthBossStartImage()
    {
        // Load ship image for Earth Boss
        return LoadImage("Game/Images/ship/earthboss.png");
    }
//Fire


}