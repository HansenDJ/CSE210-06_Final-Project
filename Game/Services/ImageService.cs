using System;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace generalNamespace;

public class ImageService
{

    // Create methods to define in the RaylibImageService class to load the image files into textures.

    //Basic assets 

    public static Image SetShipStartImage()
    {
        // Load ship image for player
        return LoadImage("Game/Images/ship/startship.png");
    }

    public static Image SetCoinStartImage()
    {
        // Load Coin image to pick up coin
        return LoadImage("Game/Images/   /    .png");
    }

    //Backgrounds
    public static Image SetEarthBGStartImage()
    {
        // Load Back Gound for Earth level
        return LoadImage("Game/Images/bg/map3earthbg.png");
    }

    public static Image SetFireBGStartImage()
    {
        // Load Back Gound for Fire level
        return LoadImage("Game/Images/bg/firebg.png");
    }

    public static Image SetAirBGStartImage()
    {
        // Load Back Gound for Air level
        return LoadImage("Game/Images/bg/airbg.png");
    }

    public static Image SetWaterBGStartImage()
    {
        // Load Back Gound for Water level
        return LoadImage("Game/Images/bg/waterbg.png");
    }

    public static Image SetShadowBGStartImage()
    {
        // Load Back Gound for Shadow level
        return LoadImage("Game/Images/bg/shadowbg.png");
    }



    //Earth
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
    public static Image SetFireOneStartImage()
    {
        // Load ship image for Fire LV 1
        return LoadImage("Game/Images/ship/firelv1.png");
    }

    public static Image SetFireTwoStartImage()
    {
        // Load ship image for Fire LV 2
        return LoadImage("Game/Images/ship/firelv2.png");
    }

    public static Image SetFireThreeStartImage()
    {
        // Load ship image for Fire LV 3
        return LoadImage("Game/Images/ship/firelv3.png");
    }

    public static Image SetFireBossStartImage()
    {
        // Load ship image for Fire Boss
        return LoadImage("Game/Images/ship/fireboss.png");
    }

    //Air or Electric
    public static Image SetAirOneStartImage()
    {
        // Load ship image for AirLV 1
        return LoadImage("Game/Images/ship/airlv1.png");
    }

    public static Image SetAirTwoStartImage()
    {
        // Load ship image for Air LV 2
        return LoadImage("Game/Images/ship/airlv2.png");
    }

    public static Image SetAirThreeStartImage()
    {
        // Load ship image for Air LV 3
        return LoadImage("Game/Images/ship/airlv3.png");
    }

    public static Image SetAirBossStartImage()
    {
        // Load ship image for Air Boss
        return LoadImage("Game/Images/ship/airboss.png");
    }

    //Water and Ice
    public static Image SetWaterOneStartImage()
    {
        // Load ship image for Water LV 1
        return LoadImage("Game/Images/ship/waterlv1.png");
    }

    public static Image SetWaterTwoStartImage()
    {
        // Load ship image for Water LV 2
        return LoadImage("Game/Images/ship/waterlv2.png");
    }

    public static Image SetWaterThreeStartImage()
    {
        // Load ship image for Water LV 3
        return LoadImage("Game/Images/ship/waterlv3.png");
    }

    public static Image SetWaterBossStartImage()
    {
        // Load ship image for Water Boss
        return LoadImage("Game/Images/ship/waterboss.png");
    }

    //Shadow...ooh scary
    public static Image SetShadowOneStartImage()
    {
        // Load ship image for Shadow LV 1
        return LoadImage("Game/Images/ship/shadowlv1.png");
    }

    public static Image SetShadowTwoStartImage()
    {
        // Load ship image for Shadow LV 2
        return LoadImage("Game/Images/ship/shadowlv2.png");
    }

    public static Image SetShadowThreeStartImage()
    {
        // Load ship image for Shadow LV 3
        return LoadImage("Game/Images/ship/shadowlv3.png");
    }

    public static Image SetShadowBossStartImage()
    {
        // Load ship image for Shadow Boss
        return LoadImage("Game/Images/ship/shadowboss.png");
    }

    //Heads Up Display
    public static Image SetHeartStartImage()
    {
        // Load Heart Icon for Health
        return LoadImage("Game/Images/    /      .png");
    }

    public static Image SetCoinCountImage()
    {
        // Load Coin Icon for HUD. This is different than the coin icon for the player to pick up.
        return LoadImage("Game/Images/    /      .png");
    }
    public static Image SetLaser1Image()
    {
        // Load Coin Icon for HUD. This is different than the coin icon for the player to pick up.
        return LoadImage("Game/Images/lasers/laser1.png");
    }
}