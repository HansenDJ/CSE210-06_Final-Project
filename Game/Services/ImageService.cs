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

    // HUD - Heads Up Display
    public static Image
        heartIconImage =
            LoadImage(
                "Game/Images/    /  **heart**  .png"); // **UNCOMMENT IN LoadAllTextures METHOD BELOW!** Heart icon for health

    public static Image coinCounterImage = LoadImage("Game/Images/coin.png"); // Coin to be displayed by coin counter

    // COINS
    public static Image
        coinDropImage =
            LoadImage(
                "Game/Images/   /  **enemycoin**  .png"); // **UNCOMMENT IN LoadAllTextures METHOD BELOW!** Coin image of coins dropped by enemies

    public static Image
        coinGifImage =
            LoadImage(
                "Game/Images/  **coingif**  .png"); // **UNCOMMENT IN LoadAllTextures METHOD BELOW!** Coin gif image

    // LASERS
    public static Image laser1Image = LoadImage("Game/Images/lasers/laser1.png"); // Laser1 image Big Blue
    public static Image laser2Image = LoadImage("Game/Images/lasers/laser2.png"); // Laser2 image Enemy Big Blue
    public static Image laser3Image = LoadImage("Game/Images/lasers/laser3.png"); // Laser3 image Big Green
    public static Image laser4Image = LoadImage("Game/Images/lasers/laser4.png"); // Laser4 image Enemy Big Green
    public static Image laser5Image = LoadImage("Game/Images/lasers/laser5.png"); // Laser5 image Big Pink
    public static Image laser6Image = LoadImage("Game/Images/lasers/laser6.png"); // Laser6 image Enemy Big Pink
    public static Image laser7Image = LoadImage("Game/Images/lasers/laser7.png"); // Laser7 image Big Red
    public static Image laser8Image = LoadImage("Game/Images/lasers/laser8.png"); // Laser8 image Enemy Big Red
    public static Image laser9Image = LoadImage("Game/Images/lasers/laser9.png"); // Laser9 image Small Red
    public static Image laser10Image = LoadImage("Game/Images/lasers/laser10.png"); // Laser10 image Small Blue
    public static Image laser11Image = LoadImage("Game/Images/lasers/laser11.png"); // Laser11 image Small Green 
    public static Image laser12Image = LoadImage("Game/Images/lasers/laser12.png"); // Laser12 image Small Pink


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

    // HUD - Heads Up Display
    public static Texture2D
        heartIconTexture =
            LoadTextureFromImage(
                heartIconImage); // **UNCOMMENT IN LoadAllTextures METHOD BELOW!** Heart icon for health

    public static Texture2D
        coinCounterTexture = LoadTextureFromImage(coinCounterImage); // Coin to be displayed by coin counter

    // COINS
    public static Texture2D
        coinDropTexture =
            LoadTextureFromImage(
                coinDropImage); // **UNCOMMENT IN LoadAllTextures METHOD BELOW!** Coin texture of coins dropped by enemies

    public static Texture2D
        coinGifTexture =
            LoadTextureFromImage(coinGifImage); // **UNCOMMENT IN LoadAllTextures METHOD BELOW!** Coin gif texture

    // LASERS
    public static Texture2D laser1Texture = LoadTextureFromImage(laser1Image); // Laser1 texture
    public static Texture2D laser2Texture = LoadTextureFromImage(laser2Image); // Laser2 texture
    public static Texture2D laser3Texture = LoadTextureFromImage(laser3Image); // Laser3 texture
    public static Texture2D laser4Texture = LoadTextureFromImage(laser4Image); // Laser4 texture
    public static Texture2D laser5Texture = LoadTextureFromImage(laser5Image); // Laser5 texture
    public static Texture2D laser6Texture = LoadTextureFromImage(laser6Image); // Laser6 texture
    public static Texture2D laser7Texture = LoadTextureFromImage(laser7Image); // Laser7 texture
    public static Texture2D laser8Texture = LoadTextureFromImage(laser8Image); // Laser8 texture
    public static Texture2D laser9Texture = LoadTextureFromImage(laser9Image); // Laser9 texture
    public static Texture2D laser10Texture = LoadTextureFromImage(laser10Image); // Laser10 texture
    public static Texture2D laser11Texture = LoadTextureFromImage(laser11Image); // Laser11 texture 
    public static Texture2D laser12Texture = LoadTextureFromImage(laser12Image); // Laser12 texture


    public static int explosionFrameLength = 15;

    private static readonly List<Image> allImages = new();
    private static readonly List<Texture2D> allTextures = new();


    /*---METHODS---*/
    // public static Texture2D GetTexture(Texture2D textureToReturn)
    // {
    //     return textureToReturn;
    // }
    public static Texture2D LoadInTexture(Image image)
    {
        var texture = LoadTextureFromImage(image);
        // UnloadImage(image);
        return texture;
    }

    public static Image UnloadImageFile(Image imageToUnload)
    {
        UnloadImage(imageToUnload);
        return imageToUnload;
    }

    public static void UnloadTextureFile(Texture2D textureToUnload)
    {
        UnloadTexture(textureToUnload);
    }

    /*---LISTS---*/
    public static List<Texture2D> LoadExplosionAnimation()
    {
        var explosionAnimation = new List<Texture2D>();
        var exp000Image = LoadImage("Game/Images/explosion/exp000.png"); // Explosion image part 0
        explosionAnimation.Add(LoadTextureFromImage(exp000Image));
        // UnloadImage(exp000Image);
        var exp001Image = LoadImage("Game/Images/explosion/exp001.png"); // Explosion image part 1
        explosionAnimation.Add(LoadTextureFromImage(exp001Image));
        // UnloadImage(exp001Image);
        var exp002Image = LoadImage("Game/Images/explosion/exp002.png"); // Explosion image part 2
        explosionAnimation.Add(LoadTextureFromImage(exp002Image));
        // UnloadImage(exp002Image);
        var exp003Image = LoadImage("Game/Images/explosion/exp003.png"); // Explosion image part 3
        explosionAnimation.Add(LoadTextureFromImage(exp003Image));
        // UnloadImage(exp003Image);
        var exp004Image = LoadImage("Game/Images/explosion/exp004.png"); // Explosion image part 4
        explosionAnimation.Add(LoadTextureFromImage(exp004Image));
        // UnloadImage(exp004Image);
        var exp005Image = LoadImage("Game/Images/explosion/exp005.png"); // Explosion image part 5
        explosionAnimation.Add(LoadTextureFromImage(exp005Image));
        // UnloadImage(exp005Image);
        var exp006Image = LoadImage("Game/Images/explosion/exp006.png"); // Explosion image part 6
        explosionAnimation.Add(LoadTextureFromImage(exp006Image));
        // UnloadImage(exp006Image);
        var exp007Image = LoadImage("Game/Images/explosion/exp007.png"); // Explosion image part 7
        explosionAnimation.Add(LoadTextureFromImage(exp007Image));
        // UnloadImage(exp007Image);
        var exp008Image = LoadImage("Game/Images/explosion/exp008.png"); // Explosion image part 8
        explosionAnimation.Add(LoadTextureFromImage(exp008Image));
        // UnloadImage(exp008Image);
        var exp009Image = LoadImage("Game/Images/explosion/exp009.png"); // Explosion image part 9
        explosionAnimation.Add(LoadTextureFromImage(exp009Image));
        // UnloadImage(exp009Image);
        var exp010Image = LoadImage("Game/Images/explosion/exp010.png"); // Explosion image part 10
        explosionAnimation.Add(LoadTextureFromImage(exp010Image));
        // UnloadImage(exp010Image);
        var exp011Image = LoadImage("Game/Images/explosion/exp011.png"); // Explosion image part 11
        explosionAnimation.Add(LoadTextureFromImage(exp011Image));
        // UnloadImage(exp011Image);
        var exp012Image = LoadImage("Game/Images/explosion/exp012.png"); // Explosion image part 12
        explosionAnimation.Add(LoadTextureFromImage(exp012Image));
        // UnloadImage(exp012Image);
        var exp013Image = LoadImage("Game/Images/explosion/exp013.png"); // Explosion image part 13
        explosionAnimation.Add(LoadTextureFromImage(exp013Image));
        // UnloadImage(exp013Image);
        var exp014Image = LoadImage("Game/Images/explosion/exp014.png"); // Explosion image part 14
        explosionAnimation.Add(LoadTextureFromImage(exp014Image));
        // UnloadImage(exp014Image);
        var exp015Image = LoadImage("Game/Images/explosion/exp015.png"); // Explosion image part 15
        explosionAnimation.Add(LoadTextureFromImage(exp015Image));
        // UnloadImage(exp015Image);

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
        //    allImages(coinCounterImage);
        //  allImages.Add(coinDropImage);  Uncomment when full file name added above
        // allImages.Add(coinGifImage);  Uncomment when full file name added above
        allImages.Add(laser1Image);
        allImages.Add(laser2Image);
        allImages.Add(laser3Image);
        allImages.Add(laser4Image);
        allImages.Add(laser5Image);
        allImages.Add(laser6Image);
        allImages.Add(laser7Image);
        allImages.Add(laser8Image);
        allImages.Add(laser9Image);
        allImages.Add(laser10Image);
        allImages.Add(laser11Image);
        allImages.Add(laser12Image);


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
        allTextures.Add(laser2Texture);
        allTextures.Add(laser3Texture);
        allTextures.Add(laser4Texture);
        allTextures.Add(laser5Texture);
        allTextures.Add(laser6Texture);
        allTextures.Add(laser7Texture);
        allTextures.Add(laser8Texture);
        allTextures.Add(laser9Texture);
        allTextures.Add(laser10Texture);
        allTextures.Add(laser11Texture);
        allTextures.Add(laser12Texture);

        return allTextures;
    }

    public static List<Image> UnloadAllImages()
    {
        for (var i = 0; i < allImages.Count; i++)
        {
            allImages[i] = UnloadImageFile(startShipImage);
            allImages[i] = UnloadImageFile(earthOneEnemyImage);
            allImages[i] = UnloadImageFile(earthTwoEnemyImage);
            allImages[i] = UnloadImageFile(earthThreeEnemyImage);
            allImages[i] = UnloadImageFile(earthBossEnemyImage);
            allImages[i] = UnloadImageFile(waterOneEnemyImage);
            allImages[i] = UnloadImageFile(waterTwoEnemyImage);
            allImages[i] = UnloadImageFile(waterThreeEnemyImage);
            allImages[i] = UnloadImageFile(waterBossEnemyImage);
            allImages[i] = UnloadImageFile(airOneEnemyImage);
            allImages[i] = UnloadImageFile(airTwoEnemyImage);
            allImages[i] = UnloadImageFile(airThreeEnemyImage);
            allImages[i] = UnloadImageFile(airBossEnemyImage);
            allImages[i] = UnloadImageFile(fireOneEnemyImage);
            allImages[i] = UnloadImageFile(fireTwoEnemyImage);
            allImages[i] = UnloadImageFile(fireThreeEnemyImage);
            allImages[i] = UnloadImageFile(fireBossEnemyImage);
            allImages[i] = UnloadImageFile(shadowOneEnemyImage);
            allImages[i] = UnloadImageFile(shadowTwoEnemyImage);
            allImages[i] = UnloadImageFile(shadowThreeEnemyImage);
            allImages[i] = UnloadImageFile(shadowBossEnemyImage);
            // allImages[i] = UnloadImageFile(heartIconImage);  Uncomment when full file name added above
            allImages[i] = UnloadImageFile(coinCounterImage);
            // allImages[i] = UnloadImageFile(coinDropImage);  Uncomment when full file name added above
            // allImages[i] = UnloadImageFile(coinGifImage);  Uncomment when full file name added above
            allImages[i] = UnloadImageFile(laser1Image);
            allImages[i] = UnloadImageFile(laser3Image);
            allImages[i] = UnloadImageFile(laser5Image);
            allImages[i] = UnloadImageFile(laser7Image);
            allImages[i] = UnloadImageFile(laser11Image);
        }

        // Director.unloadCheck = true;

        return allImages;
    }
}