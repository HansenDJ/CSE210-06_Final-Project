using generalNamespace.Laser;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace generalNamespace;

public class VideoService
{
    public static int scrnWidth = 1400;
    public static int scrnHeight = 850;

    // public static double FullPrimaryScreenWidth { get; }
    // public static double FullPrimaryScreenHeight { get; }
    // public static int scrnWidth = Convert.ToInt32(FullPrimaryScreenWidth);
    // public static int scrnHeight = Convert.ToInt32( FullPrimaryScreenHeight);

    public static void Draw(List<Enemy> enemiesDraw, List<Weapon> playerWeaponsToDraw, Player player,
        BackgroundService bg, Coin coin, List<Weapon> enemyWeaponsToDraw, List<Coordinate> ExplosionC)
    {
        DrawBackdrop(bg);
        DrawCoinCount(coin);
        DrawHeartCount();
        DrawCharacters(enemiesDraw, playerWeaponsToDraw, player, enemyWeaponsToDraw);
        ExplosionAnimation(ExplosionC);
        DrawPlayer(player);
    }

    private static void DrawBackdrop(BackgroundService bg)
    {
        ClearBackground(BLACK);
        DrawTexture(bg.bg1Texture, bg.x1, bg.y1, WHITE);
        DrawTexture(bg.bg2Texture, bg.x2, bg.y2, WHITE);
    }

    private static void DrawCharacters(List<Enemy> enemiesToDraw, List<Weapon> weaponsToDraw, Player player,
        List<Weapon> EnemyWeaponsToDraw)
    {
        //   Console.WriteLine( "Object Count: " + enemiesToDraw.Count().ToString() + " Weapon Count: " + weaponsToDraw.Count().ToString());
        for (var i = 0; i < enemiesToDraw.Count - 1; i++)
        {
            DrawCharacter(enemiesToDraw[i]);
            DrawColliderBox(enemiesToDraw[i]);
        }

       
        for (var i = 0; i < weaponsToDraw.Count - 1; i++)
        {
            if (!weaponsToDraw[i].location && weaponsToDraw[i].powerUpShot == 1)
            {
                weaponsToDraw[i].offsetW = 5;
                weaponsToDraw[i].offsetH = 10;
                weaponsToDraw[i].SetOffsetColliderWidth(player.offsetW);
                weaponsToDraw[i].SetOffsetColliderHeight(player.offsetH);
                weaponsToDraw[i].SetX(player.x + player.GetColliderBoxWidth());
                weaponsToDraw[i].SetY(player.y + player.GetColliderBoxHeight() / 2);
                weaponsToDraw[i].location = true;
            }else if (!weaponsToDraw[i].location && !(weaponsToDraw[i].powerUpShot == 1))
            {
                weaponsToDraw[i].location = true;
                
            }
            

            DrawCharacter(weaponsToDraw[i]);
            DrawColliderBox(weaponsToDraw[i]);
        }

        for (var i = 0; i < EnemyWeaponsToDraw.Count - 1; i++)
        {
            // // int enemyX = enemiesToDraw[EnemyWeaponsToDraw[i].enemyIndex].x;
            // // int enemyY = enemiesToDraw[EnemyWeaponsToDraw[i].enemyIndex].y;
            // EnemyWeaponsToDraw[i].SetOffsetColliderWidth(EnemyWeaponsToDraw[i].offsetW);
            // EnemyWeaponsToDraw[i].SetOffsetColliderHeight(EnemyWeaponsToDraw[i].offsetH);
            // EnemyWeaponsToDraw[i].SetX(EnemyWeaponsToDraw[i].x - EnemyWeaponsToDraw[i].GetColliderBoxWidth());
            // EnemyWeaponsToDraw[i].SetY(EnemyWeaponsToDraw[i].y - EnemyWeaponsToDraw[i].GetColliderBoxHeight() / 2);

            if (!EnemyWeaponsToDraw[i].location)
            {
                EnemyWeaponsToDraw[i].offsetW = EnemyWeaponsToDraw[i].offsetW;
                EnemyWeaponsToDraw[i].offsetH = EnemyWeaponsToDraw[i].offsetH;
                EnemyWeaponsToDraw[i].SetOffsetColliderWidth(EnemyWeaponsToDraw[i].offsetW);
                EnemyWeaponsToDraw[i].SetOffsetColliderHeight(EnemyWeaponsToDraw[i].offsetH);
                EnemyWeaponsToDraw[i].SetX(EnemyWeaponsToDraw[i].x - EnemyWeaponsToDraw[i].GetColliderBoxWidth());
                EnemyWeaponsToDraw[i].SetY(EnemyWeaponsToDraw[i].y - EnemyWeaponsToDraw[i].GetColliderBoxHeight() / 2);
                EnemyWeaponsToDraw[i].location = true;
            }

            DrawCharacter(EnemyWeaponsToDraw[i]);
            DrawColliderBox(EnemyWeaponsToDraw[i]);
        }
    }

    public static void DrawCharacter(Character characterToDraw) // draws an artifact
    {
        // This method should be able to draw enemy ships, player and enemy weapons.
        DrawTexture(characterToDraw.charTexture, characterToDraw.x, characterToDraw.y, WHITE);
    }

    public static void ExplosionAnimation(List<Coordinate> e)
    {
        for (var i = 0; i < e.Count; i++)
            DrawTexture(ImageService.LoadExplosionAnimation()[e[i].frame], e[i].x, e[i].y, WHITE);
    }

    public static void DrawPlayer(Player player)
    {
        DrawTexture(player.GetCharTexture(), player.x, player.y, WHITE);
        DrawColliderBox(player);
    }


    public static void DrawCoinCount(Coin coin)
    {
        DrawText($"{CurrencyHandler.money}", 1250, 22, 20, WHITE);
        DrawTexture(ImageService.coinCounterTexture, 1220, 20, WHITE);
        DrawText($"{Convert.ToInt32(DifficultyHandler.currentLevel * Director.levelTime - Director.secondsPassed)}", 650, 22, 20, WHITE);
      
    }

    public static void DrawHeartCount()
    {
        DrawTexture(ImageService.heartIconTexture, 1220, 55, WHITE);
        DrawText($"{PlayerStats.playerHealth}/{PlayerStats.maxPlayerHealth}", 1250, 55, 20, WHITE);
        if (Powerup.effectTime > 0)
        {
            DrawText(Convert.ToInt32(Math.Floor(Powerup.effectTime)).ToString(), 100, 55, 20, WHITE);
        }
        
    }

    public static void DrawColliderBox(Character character)
    {
        DrawRectangleLines(character.x + character.GetOffsetColliderWidth() / 2,
            character.y + character.GetOffsetColliderHeight() / 2, character.GetColliderBoxWidth(),
            character.GetColliderBoxHeight(), GREEN);
    }
}