using Raylib_cs;
using static Raylib_cs.Raylib;

namespace generalNamespace;

public static class ImageService
{
    // BACKGROUND IMAGES
    public static Image earthBGStartImage = LoadImage("Game/Images/bg/map1earthbg.png"); // Background for earth level
    public static Image waterBGStartImage = LoadImage("Game/Images/bg/map2waterbg.png"); // Background for water level
    public static Image airBGStartImage = LoadImage("Game/Images/bg/map3airbg.png"); // Background for air level

    public static Image fireBGStartImage = LoadImage("Game/Images/bg/map4firebg.png"); // Background for fire level

    public static Image
        shadowBGStartImage = LoadImage("Game/Images/bg/map5shadowbg.png"); // Background for shadow level

    // BACKGROUND TEXTURES
    public static Texture2D earthBGStartTexture = LoadTextureFromImage(earthBGStartImage);
    public static Texture2D waterBGStartTexture = LoadTextureFromImage(waterBGStartImage);
    public static Texture2D airBGStartTexture = LoadTextureFromImage(airBGStartImage);
    public static Texture2D fireBGStartTexture = LoadTextureFromImage(fireBGStartImage);
    public static Texture2D shadowBGStartTexture = LoadTextureFromImage(shadowBGStartImage);


    /*---IMAGES---*/
    // PLAYER
    public static Image startShipImage = LoadImage("Game/Images/ship/startship.png"); // Ship image for player

    // ENEMIES
        // Earth enemies
    public static Image earthOneEnemyImage = LoadImage("Game/Images/ship/earthlv1.png"); // Enemy earth lv 1
    public static Image earthTwoEnemyImage = LoadImage("Game/Images/ship/earthlv2.png"); // Enemy earth lv 2
    public static Image earthThreeEnemyImage = LoadImage("Game/Images/ship/earthlv3.png"); // Enemy earth lv 3

    public static Image earthBossEnemyImage = LoadImage("Game/Images/ship/earthboss.png"); // Boss enemy earth

        // Water enemies
    public static Image waterOneEnemyImage = LoadImage("Game/Images/ship/waterlv1.png"); // Enemy water lv 1
    public static Image waterTwoEnemyImage = LoadImage("Game/Images/ship/waterlv2.png"); // Enemy water lv 2
    public static Image waterThreeEnemyImage = LoadImage("Game/Images/ship/waterlv3.png"); // Enemy water lv 3

    public static Image waterBossEnemyImage = LoadImage("Game/Images/ship/waterboss.png"); // Boss enemy water

        // Air enemies
    public static Image airOneEnemyImage = LoadImage("Game/Images/ship/airlv1.png"); // Enemy air lv 1
    public static Image airTwoEnemyImage = LoadImage("Game/Images/ship/airlv2.png"); // Enemy air lv 2
    public static Image airThreeEnemyImage = LoadImage("Game/Images/ship/airlv3.png"); // Enemy air lv 3

    public static Image airBossEnemyImage = LoadImage("Game/Images/ship/airboss.png"); // Boss enemy air

        // Fire enemies
    public static Image fireOneEnemyImage = LoadImage("Game/Images/ship/firelv1.png"); // Enemy fire lv 1
    public static Image fireTwoEnemyImage = LoadImage("Game/Images/ship/firelv2.png"); // Enemy fire lv 2
    public static Image fireThreeEnemyImage = LoadImage("Game/Images/ship/firelv3.png"); // Enemy fire lv 3

    public static Image fireBossEnemyImage = LoadImage("Game/Images/ship/fireboss.png"); // Boss enemy fire

        // Shadow enemies
    public static Image shadowOneEnemyImage = LoadImage("Game/Images/ship/shadowlv1.png"); // Enemy shadow lv 1
    public static Image shadowTwoEnemyImage = LoadImage("Game/Images/ship/shadowlv2.png"); // Enemy shadow lv 2
    public static Image shadowThreeEnemyImage = LoadImage("Game/Images/ship/shadowlv3.png"); // Enemy shadow lv 3

    public static Image shadowBossEnemyImage = LoadImage("Game/Images/ship/shadowboss.png"); // Boss enemy shadow

    // EXPLOSION
    public static Image exp000Image = LoadImage("Game/Images/explosion/exp000.png"); // Explosion image part 0
    public static Image exp001Image = LoadImage("Game/Images/explosion/exp001.png"); // Explosion image part 1
    public static Image exp002Image = LoadImage("Game/Images/explosion/exp002.png"); // Explosion image part 2
    public static Image exp003Image = LoadImage("Game/Images/explosion/exp003.png"); // Explosion image part 3
    public static Image exp004Image = LoadImage("Game/Images/explosion/exp004.png"); // Explosion image part 4
    public static Image exp005Image = LoadImage("Game/Images/explosion/exp005.png"); // Explosion image part 5
    public static Image exp006Image = LoadImage("Game/Images/explosion/exp006.png"); // Explosion image part 6
    public static Image exp007Image = LoadImage("Game/Images/explosion/exp007.png"); // Explosion image part 7
    public static Image exp008Image = LoadImage("Game/Images/explosion/exp008.png"); // Explosion image part 8
    public static Image exp009Image = LoadImage("Game/Images/explosion/exp009.png"); // Explosion image part 9
    public static Image exp010Image = LoadImage("Game/Images/explosion/exp010.png"); // Explosion image part 10
    public static Image exp011Image = LoadImage("Game/Images/explosion/exp011.png"); // Explosion image part 11
    public static Image exp012Image = LoadImage("Game/Images/explosion/exp012.png"); // Explosion image part 12
    public static Image exp013Image = LoadImage("Game/Images/explosion/exp013.png"); // Explosion image part 13
    public static Image exp014Image = LoadImage("Game/Images/explosion/exp014.png"); // Explosion image part 14
    public static Image exp015Image = LoadImage("Game/Images/explosion/exp015.png"); // Explosion image part 15

    // HUD - Heads Up Display
    public static Image heartIconImage = LoadImage("Game/Images/    /  **heart**  .png"); // **UNCOMMENT IN LoadAllTextures METHOD BELOW!** Heart icon for health

    public static Image coinCounterImage = LoadImage("Game/Images/coin.png"); // Coin to be displayed by coin counter

    // COINS
    public static Image coinDropImage = LoadImage("Game/Images/   /  **enemycoin**  .png"); // **UNCOMMENT IN LoadAllTextures METHOD BELOW!** Coin image of coins dropped by enemies

    public static Image coinGifImage = LoadImage("Game/Images/  **coingif**  .png"); // **UNCOMMENT IN LoadAllTextures METHOD BELOW!** Coin gif image

    // LASERS
    public static Image laser1Image = LoadImage("Game/Images/lasers/laser1.png"); // Laser1 image
    public static Image laser3Image = LoadImage("Game/Images/lasers/laser3.png"); // Laser3 image
    public static Image laser5Image = LoadImage("Game/Images/lasers/laser5.png"); // Laser5 image
    public static Image laser7Image = LoadImage("Game/Images/lasers/laser7.png"); // Laser7 image
    public static Image laser11Image = LoadImage("Game/Images/lasers/laser11.png"); // Laser11 image


    /*---Textures---*/
    // PLAYER
    public static Texture2D startShipTexture = LoadTextureFromImage(startShipImage); // Ship texture for player

    // ENEMIES
        // Earth enemies
    public static Texture2D earthOneEnemyTexture = LoadTextureFromImage(earthOneEnemyImage); // Enemy earth lv 1
    public static Texture2D earthTwoEnemyTexture = LoadTextureFromImage(earthTwoEnemyImage); // Enemy earth lv 2
    public static Texture2D earthThreeEnemyTexture = LoadTextureFromImage(earthThreeEnemyImage); // Enemy earth lv 3

    public static Texture2D earthBossEnemyTexture = LoadTextureFromImage(earthBossEnemyImage); // Boss enemy earth

        // Water enemies
    public static Texture2D waterOneEnemyTexture = LoadTextureFromImage(waterOneEnemyImage); // Enemy water lv 1
    public static Texture2D waterTwoEnemyTexture = LoadTextureFromImage(waterTwoEnemyImage); // Enemy water lv 2
    public static Texture2D waterThreeEnemyTexture = LoadTextureFromImage(waterThreeEnemyImage); // Enemy water lv 3

    public static Texture2D waterBossEnemyTexture = LoadTextureFromImage(waterBossEnemyImage); // Boss enemy water

        // Air enemies
    public static Texture2D airOneEnemyTexture = LoadTextureFromImage(airOneEnemyImage); // Enemy air lv 1
    public static Texture2D airTwoEnemyTexture = LoadTextureFromImage(airTwoEnemyImage); // Enemy air lv 2
    public static Texture2D airThreeEnemyTexture = LoadTextureFromImage(airThreeEnemyImage); // Enemy air lv 3

    public static Texture2D airBossEnemyTexture = LoadTextureFromImage(airBossEnemyImage); // Boss enemy air

        // Fire enemies
    public static Texture2D fireOneEnemyTexture = LoadTextureFromImage(fireOneEnemyImage); // Enemy fire lv 1
    public static Texture2D fireTwoEnemyTexture = LoadTextureFromImage(fireTwoEnemyImage); // Enemy fire lv 2
    public static Texture2D fireThreeEnemyTexture = LoadTextureFromImage(fireThreeEnemyImage); // Enemy fire lv 3

    public static Texture2D fireBossEnemyTexture = LoadTextureFromImage(fireBossEnemyImage); // Boss enemy fire

        // Shadow enemies
    public static Texture2D shadowOneEnemyTexture = LoadTextureFromImage(shadowOneEnemyImage); // Enemy shadow lv 1
    public static Texture2D shadowTwoEnemyTexture = LoadTextureFromImage(shadowTwoEnemyImage); // Enemy shadow lv 2
    public static Texture2D shadowThreeEnemyTexture = LoadTextureFromImage(shadowThreeEnemyImage); // Enemy shadow lv 3

    public static Texture2D shadowBossEnemyTexture = LoadTextureFromImage(shadowBossEnemyImage); // Boss enemy shadow

    // EXPLOSION
    public static Texture2D exp000Texture = LoadTextureFromImage(exp000Image); // Explosion texture part 0
    public static Texture2D exp001Texture = LoadTextureFromImage(exp001Image); // Explosion texture part 1
    public static Texture2D exp002Texture = LoadTextureFromImage(exp002Image); // Explosion texture part 2
    public static Texture2D exp003Texture = LoadTextureFromImage(exp003Image); // Explosion texture part 3
    public static Texture2D exp004Texture = LoadTextureFromImage(exp004Image); // Explosion texture part 4
    public static Texture2D exp005Texture = LoadTextureFromImage(exp005Image); // Explosion texture part 5
    public static Texture2D exp006Texture = LoadTextureFromImage(exp006Image); // Explosion texture part 6
    public static Texture2D exp007Texture = LoadTextureFromImage(exp007Image); // Explosion texture part 7
    public static Texture2D exp008Texture = LoadTextureFromImage(exp008Image); // Explosion texture part 8
    public static Texture2D exp009Texture = LoadTextureFromImage(exp009Image); // Explosion texture part 9
    public static Texture2D exp010Texture = LoadTextureFromImage(exp010Image); // Explosion texture part 10
    public static Texture2D exp011Texture = LoadTextureFromImage(exp011Image); // Explosion texture part 11
    public static Texture2D exp012Texture = LoadTextureFromImage(exp012Image); // Explosion texture part 12
    public static Texture2D exp013Texture = LoadTextureFromImage(exp013Image); // Explosion texture part 13
    public static Texture2D exp014Texture = LoadTextureFromImage(exp014Image); // Explosion texture part 14
    public static Texture2D exp015Texture = LoadTextureFromImage(exp015Image); // Explosion texture part 15

    // HUD - Heads Up Display
    public static Texture2D
        heartIconTexture = LoadTextureFromImage(heartIconImage); // **UNCOMMENT IN LoadAllTextures METHOD BELOW!** Heart icon for health

    public static Texture2D coinCounterTexture = LoadTextureFromImage(coinCounterImage); // Coin to be displayed by coin counter

    // COINS
    public static Texture2D coinDropTexture = LoadTextureFromImage(coinDropImage); // **UNCOMMENT IN LoadAllTextures METHOD BELOW!** Coin texture of coins dropped by enemies

    public static Texture2D coinGifTexture = LoadTextureFromImage(coinGifImage); // **UNCOMMENT IN LoadAllTextures METHOD BELOW!** Coin gif texture

    // LASERS
    public static Texture2D laser1Texture = LoadTextureFromImage(laser1Image); // Laser1 texture
    public static Texture2D laser3Texture = LoadTextureFromImage(laser3Image); // Laser3 texture
    public static Texture2D laser5Texture = LoadTextureFromImage(laser5Image); // Laser5 texture
    public static Texture2D laser7Texture = LoadTextureFromImage(laser7Image); // Laser7 texture
    public static Texture2D laser11Texture = LoadTextureFromImage(laser11Image); // Laser11 texture 


    public static int explosionFrameLength = 16;

    private static readonly List<Image> allImages = new();
    private static readonly List<Texture2D> allTextures = new();


    /*---METHODS---*/
    // public static Texture2D GetTexture(Texture2D textureToReturn)
    // {
    //     return textureToReturn;
    // }
    public static void LoadInTexture(Image image)
    {
        Texture2D textureToLoad = LoadTextureFromImage(image);
    }

    public static void UnloadImageFile(Image imageToUnload)
    {
        UnloadImage(imageToUnload);
    }

    public static void UnloadTextureFile(Texture2D textureToUnload)
    {
        UnloadTexture(textureToUnload);
    }

    /*---LISTS---*/
    public static List<Texture2D> LoadExplosionAnimation()
    {
        List<Texture2D> explosionAnimation = new List<Texture2D>();
            explosionAnimation.Add(exp000Texture);
            explosionAnimation.Add(exp001Texture);
            explosionAnimation.Add(exp002Texture);
            explosionAnimation.Add(exp003Texture);
            explosionAnimation.Add(exp004Texture);
            explosionAnimation.Add(exp005Texture);
            explosionAnimation.Add(exp006Texture);
            explosionAnimation.Add(exp007Texture);
            explosionAnimation.Add(exp008Texture);
            explosionAnimation.Add(exp009Texture);
            explosionAnimation.Add(exp010Texture);
            explosionAnimation.Add(exp011Texture);
            explosionAnimation.Add(exp012Texture);
            explosionAnimation.Add(exp013Texture);
            explosionAnimation.Add(exp014Texture);
            explosionAnimation.Add(exp015Texture);

        return explosionAnimation;
    }

    public static List<Image> LoadAllImages()
    {
        allImages.Add(startShipImage);
        allImages.Add(earthOneEnemyImage);
        allImages.Add(earthTwoEnemyImage);
        allImages.Add(earthThreeEnemyImage);
        allImages.Add(earthBossEnemyImage);
        allImages.Add(waterOneEnemyImage);
        allImages.Add(waterTwoEnemyImage);
        allImages.Add(waterThreeEnemyImage);
        allImages.Add(waterBossEnemyImage);
        allImages.Add(airOneEnemyImage);
        allImages.Add(airTwoEnemyImage);
        allImages.Add(airThreeEnemyImage);
        allImages.Add(airBossEnemyImage);
        allImages.Add(fireOneEnemyImage);
        allImages.Add(fireTwoEnemyImage);
        allImages.Add(fireThreeEnemyImage);
        allImages.Add(fireBossEnemyImage);
        allImages.Add(shadowOneEnemyImage);
        allImages.Add(shadowTwoEnemyImage);
        allImages.Add(shadowThreeEnemyImage);
        allImages.Add(shadowBossEnemyImage);
        // allImages.Add(coinCounterImage);
        // allImages.Add(coinDropImage);  Uncomment when full file name added above
        // allImages.Add(coinGifImage);  Uncomment when full file name added above
        allImages.Add(laser1Image);
        allImages.Add(laser3Image);
        allImages.Add(laser5Image);
        allImages.Add(laser7Image);
        allImages.Add(laser11Image);
        allImages.Add(exp000Image);
        allImages.Add(exp001Image);
        allImages.Add(exp002Image);
        allImages.Add(exp003Image);
        allImages.Add(exp004Image);
        allImages.Add(exp005Image);
        allImages.Add(exp006Image);
        allImages.Add(exp007Image);
        allImages.Add(exp008Image);
        allImages.Add(exp009Image);
        allImages.Add(exp010Image);
        allImages.Add(exp011Image);
        allImages.Add(exp012Image);
        allImages.Add(exp013Image);
        allImages.Add(exp014Image);
        allImages.Add(exp015Image);

        return allImages;
    }

    public static List<Texture2D> LoadAllTextures()
    {
        allTextures.Add(startShipTexture);
        allTextures.Add(earthOneEnemyTexture);
        allTextures.Add(earthTwoEnemyTexture);
        allTextures.Add(earthThreeEnemyTexture);
        allTextures.Add(earthBossEnemyTexture);
        allTextures.Add(waterOneEnemyTexture);
        allTextures.Add(waterTwoEnemyTexture);
        allTextures.Add(waterThreeEnemyTexture);
        allTextures.Add(waterBossEnemyTexture);
        allTextures.Add(airOneEnemyTexture);
        allTextures.Add(airTwoEnemyTexture);
        allTextures.Add(airThreeEnemyTexture);
        allTextures.Add(airBossEnemyTexture);
        allTextures.Add(fireOneEnemyTexture);
        allTextures.Add(fireTwoEnemyTexture);
        allTextures.Add(fireThreeEnemyTexture);
        allTextures.Add(fireBossEnemyTexture);
        allTextures.Add(shadowOneEnemyTexture);
        allTextures.Add(shadowTwoEnemyTexture);
        allTextures.Add(shadowThreeEnemyTexture);
        allTextures.Add(shadowBossEnemyTexture);
        // allTextures.Add(heartIconTexture);  Uncomment when full file name added above
        allTextures.Add(coinCounterTexture);
        // allTextures.Add(coinDropTexture);  Uncomment when full file name added above
        // allTextures.Add(coinGifTexture);  Uncomment when full file name added above
        allTextures.Add(laser1Texture);
        allTextures.Add(laser3Texture);
        allTextures.Add(laser5Texture);
        allTextures.Add(laser7Texture);
        allTextures.Add(laser11Texture);

        return allTextures;
    }

    public static void UnloadAllImages()
    {
        UnloadImage(startShipImage);
        UnloadImage(earthOneEnemyImage);
        UnloadImage(earthTwoEnemyImage);
        UnloadImage(earthThreeEnemyImage);
        UnloadImage(earthBossEnemyImage);
        UnloadImage(waterOneEnemyImage);
        UnloadImage(waterTwoEnemyImage);
        UnloadImage(waterThreeEnemyImage);
        UnloadImage(waterBossEnemyImage);
        UnloadImage(airOneEnemyImage);
        UnloadImage(airTwoEnemyImage);
        UnloadImage(airThreeEnemyImage);
        UnloadImage(airBossEnemyImage);
        UnloadImage(fireOneEnemyImage);
        UnloadImage(fireTwoEnemyImage);
        UnloadImage(fireThreeEnemyImage);
        UnloadImage(fireBossEnemyImage);
        UnloadImage(shadowOneEnemyImage);
        UnloadImage(shadowTwoEnemyImage);
        UnloadImage(shadowThreeEnemyImage);
        UnloadImage(shadowBossEnemyImage);
        // UnloadImage(heartIconImage);  Uncomment when full file name added above
        UnloadImage(coinCounterImage);
        // UnloadImage(coinDropImage);  Uncomment when full file name added above
        // UnloadImage(coinGifImage);  Uncomment when full file name added above
        UnloadImage(laser1Image);
        UnloadImage(laser3Image);
        UnloadImage(laser5Image);
        UnloadImage(laser7Image);
        UnloadImage(laser11Image);
        UnloadImage(exp000Image);
        UnloadImage(exp001Image);
        UnloadImage(exp002Image);
        UnloadImage(exp003Image);
        UnloadImage(exp004Image);
        UnloadImage(exp005Image);
        UnloadImage(exp006Image);
        UnloadImage(exp007Image);
        UnloadImage(exp008Image);
        UnloadImage(exp009Image);
        UnloadImage(exp010Image);
        UnloadImage(exp011Image);
        UnloadImage(exp012Image);
        UnloadImage(exp013Image);
        UnloadImage(exp014Image);
        UnloadImage(exp015Image);

        // Director.unloadCheck = true;
    }

    public static void UnloadAllTextures()
    {
        UnloadTexture(startShipTexture);
        UnloadTexture(earthOneEnemyTexture);
        UnloadTexture(earthTwoEnemyTexture);
        UnloadTexture(earthThreeEnemyTexture);
        UnloadTexture(earthBossEnemyTexture);
        UnloadTexture(waterOneEnemyTexture);
        UnloadTexture(waterTwoEnemyTexture);
        UnloadTexture(waterThreeEnemyTexture);
        UnloadTexture(waterBossEnemyTexture);
        UnloadTexture(airOneEnemyTexture);
        UnloadTexture(airTwoEnemyTexture);
        UnloadTexture(airThreeEnemyTexture);
        UnloadTexture(airBossEnemyTexture);
        UnloadTexture(fireOneEnemyTexture);
        UnloadTexture(fireTwoEnemyTexture);
        UnloadTexture(fireThreeEnemyTexture);
        UnloadTexture(fireBossEnemyTexture);
        UnloadTexture(shadowOneEnemyTexture);
        UnloadTexture(shadowTwoEnemyTexture);
        UnloadTexture(shadowThreeEnemyTexture);
        UnloadTexture(shadowBossEnemyTexture);
        // UnloadTexture(heartIconTexture);  Uncomment when full file name added above
        UnloadTexture(coinCounterTexture);
        // UnloadTexture(coinDropTexture);  Uncomment when full file name added above
        // UnloadTexture(coinGifTexture);  Uncomment when full file name added above
        UnloadTexture(laser1Texture);
        UnloadTexture(laser3Texture);
        UnloadTexture(laser5Texture);
        UnloadTexture(laser7Texture);
        UnloadTexture(laser11Texture);
        UnloadTexture(exp000Texture);
        UnloadTexture(exp001Texture);
        UnloadTexture(exp002Texture);
        UnloadTexture(exp003Texture);
        UnloadTexture(exp004Texture);
        UnloadTexture(exp005Texture);
        UnloadTexture(exp006Texture);
        UnloadTexture(exp007Texture);
        UnloadTexture(exp008Texture);
        UnloadTexture(exp009Texture);
        UnloadTexture(exp010Texture);
        UnloadTexture(exp011Texture);
        UnloadTexture(exp012Texture);
        UnloadTexture(exp013Texture);
        UnloadTexture(exp014Texture);
        UnloadTexture(exp015Texture);

        // Director.unloadCheck = true;
    }
}