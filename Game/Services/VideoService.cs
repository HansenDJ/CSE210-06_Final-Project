using System.Diagnostics;
using generalNamespace.Laser;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace generalNamespace;

public class VideoService
{
    public static int scrnWidth = 1400;
    public static int scrnHeight = 850;
    Random rnd = new Random();

    // public static double FullPrimaryScreenWidth { get; }
    // public static double FullPrimaryScreenHeight { get; }
    // public static int scrnWidth = Convert.ToInt32(FullPrimaryScreenWidth);
    // public static int scrnHeight = Convert.ToInt32( FullPrimaryScreenHeight);

    public static void Draw(List<Enemy> enemiesDraw, List<Weapon> playerWeaponsToDraw, Player player,
        BackgroundService bg, Coin coin, List<Coordinate> ExplosionC,
        List<PowerUpGraphic> powerUpGraphics)
    {
        DrawCoinCount(coin);
        DrawHeartCount();
        DrawPowerUpShield();
        DrawPowerUpRicochet();
        DrawPowerUpHit1();
        DrawPowerUpHit2();
        DrawPowerUpCoin();
        DrawPowerUpRestoreHealth();
        DrawWaveText();
        DrawlevelText();
        DrawPowerUpList(powerUpGraphics);
        DrawCharacters(enemiesDraw, playerWeaponsToDraw, player);
        ExplosionAnimation(ExplosionC);
        
        DrawPlayer(player);
    }

    public static void DrawPowerUpList(List<PowerUpGraphic> powerups) 
    {
        for (int i = 0; i < powerups.Count; i++)
        {
            DrawTexture(powerups[i].GetCharTexture(),powerups[i].x,powerups[i].y,Color.WHITE);
        //    DrawColliderBox(powerups[i]);
           
        }
    }

 
    public static void DrawBackdrop(BackgroundService bg)
    {
        ClearBackground(BLACK);
        DrawTexture(bg.bg1Texture, bg.x1, bg.y1, WHITE);
        DrawTexture(bg.bg2Texture, bg.x2, bg.y2, WHITE);
    }

    private static void DrawCharacters(List<Enemy> enemiesToDraw, List<Weapon> weaponsToDraw, Player player)
    {
        //   Console.WriteLine( "Object Count: " + enemiesToDraw.Count().ToString() + " Weapon Count: " + weaponsToDraw.Count().ToString());
        for (int i_enemy = 0; i_enemy < enemiesToDraw.Count - 1; i_enemy++)
        {
            Debug.Assert(0 <= i_enemy & i_enemy < enemiesToDraw.Count, "ASSERT: i_enemy out of range!");
            DrawCharacter(enemiesToDraw[i_enemy]);
          //  DrawColliderBox(enemiesToDraw[i_enemy]);
        }

       
        for (int i_playerWeapon = 0; i_playerWeapon < weaponsToDraw.Count - 1; i_playerWeapon++)
        {
            Debug.Assert(0 <= i_playerWeapon & i_playerWeapon < weaponsToDraw.Count, "ASSERT: i_playerWeapon out of range!");
            if (!weaponsToDraw[i_playerWeapon].location && weaponsToDraw[i_playerWeapon].powerUpShot == 1)
            {
                weaponsToDraw[i_playerWeapon].offsetW = 5;
                weaponsToDraw[i_playerWeapon].offsetH = 10;
                weaponsToDraw[i_playerWeapon].SetOffsetColliderWidth(player.offsetW);
                weaponsToDraw[i_playerWeapon].SetOffsetColliderHeight(player.offsetH);
                weaponsToDraw[i_playerWeapon].SetX(player.x + player.GetColliderBoxWidth());
                weaponsToDraw[i_playerWeapon].SetY(player.y + player.GetColliderBoxHeight() / 2);
                weaponsToDraw[i_playerWeapon].location = true;
            }else if (!weaponsToDraw[i_playerWeapon].location && !(weaponsToDraw[i_playerWeapon].powerUpShot == 1))
            {
                weaponsToDraw[i_playerWeapon].location = true;
                
            }
            

            DrawCharacter(weaponsToDraw[i_playerWeapon]);
      //      DrawColliderBox(weaponsToDraw[i_playerWeapon]);
        }

        
    }

    public static void DrawEnemyWeapons(int index_enemy, List<Enemy> enemyToDraw, List<Weapon> enemyWeaponsToDraw)
    {
        for (int i_weaponEnemy = 0; i_weaponEnemy < enemyWeaponsToDraw.Count - 1; i_weaponEnemy++)
        {
            Debug.Assert(0 <= i_weaponEnemy & i_weaponEnemy < enemyWeaponsToDraw.Count, "ASSERT: i_weaponEnemy out of range!");
            
            if (!enemyWeaponsToDraw[i_weaponEnemy].location && enemyWeaponsToDraw[i_weaponEnemy].laserID == enemyToDraw[index_enemy].enemyID)
            {
                if (enemyToDraw[index_enemy].levelOfEnemy == 100)
                {
                    enemyWeaponsToDraw[i_weaponEnemy].SetX(enemyToDraw[index_enemy].x - 50);
                    enemyWeaponsToDraw[i_weaponEnemy].SetY(enemyToDraw[index_enemy].y + enemyWeaponsToDraw[i_weaponEnemy].randomBossWeaponY);
                }
                else
                {
                    enemyWeaponsToDraw[i_weaponEnemy].SetX(enemyToDraw[index_enemy].x);
                    enemyWeaponsToDraw[i_weaponEnemy].SetY(enemyToDraw[index_enemy].y + enemyToDraw[index_enemy].GetColliderBoxHeight() / 2);
                    DrawCharacter(enemyWeaponsToDraw[i_weaponEnemy]);
                    // DrawColliderBox(enemyWeaponsToDraw[i_weaponEnemy]);
                }

                enemyWeaponsToDraw[i_weaponEnemy].location = true;
            }
            else if (enemyWeaponsToDraw[i_weaponEnemy].location)
            {
                DrawCharacter(enemyWeaponsToDraw[i_weaponEnemy]);
              //  DrawColliderBox(enemyWeaponsToDraw[i_weaponEnemy]);
            }

            // for (int index_enemy = 0; index_enemy < enemyToDraw.Count - 1; index_enemy++)
            // {
            //     if (!enemyWeaponsToDraw[i_weaponEnemy].location)
            //     {
            //         Debug.Assert(0 <= index_enemy & index_enemy < enemyToDraw.Count, "ASSERT: index_enemy out of range!");
            //         enemyWeaponsToDraw[i_weaponEnemy].enemyIndex = index_enemy;
            //         enemyWeaponsToDraw[i_weaponEnemy].SetOffsetColliderWidth(enemyToDraw[index_enemy].offsetW);
            //         enemyWeaponsToDraw[i_weaponEnemy].SetOffsetColliderHeight(enemyToDraw[index_enemy].offsetH);
            //         enemyWeaponsToDraw[i_weaponEnemy].SetX(enemyToDraw[index_enemy].x);
            //         enemyWeaponsToDraw[i_weaponEnemy].SetY(enemyToDraw[index_enemy].y + enemyToDraw[index_enemy].GetColliderBoxHeight() / 2);

            //         enemyWeaponsToDraw[i_weaponEnemy].location = true;
            //     }
            //     DrawCharacter(enemyWeaponsToDraw[i_weaponEnemy]);
            //     DrawColliderBox(enemyWeaponsToDraw[i_weaponEnemy]);
            // }
            
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
        {
            Debug.Assert(0 <= i & i < e.Count, "ASSERT: i, for explosion, out of range!");
            DrawTexture(ImageService.LoadExplosionAnimation()[e[i].frame], e[i].x, e[i].y, WHITE);
        }
    }

    public static void DrawPlayer(Player player)
    {
        DrawTexture(player.GetCharTexture(), player.x, player.y, WHITE);
        if (Powerup.isShielded)
        {
            player.SetOffsetColliderWidth(0);
            player.SetOffsetColliderHeight(0);
            DrawColliderBox(player);
        }
        // DrawColliderBox(player);
        
    }
    
    
    public static void DrawCoinCount(Coin coin)
    {
        DrawText($"{CurrencyHandler.money}", 160, 5, 20, WHITE);
        DrawTexture(ImageService.coinCounterTexture, 135, 2, WHITE);
        
      
    }

    public static void DrawHeartCount()
    {
        DrawTexture(ImageService.heartIconTexture, 5, 2, WHITE);
        DrawText($"{PlayerStats.playerHealth}/{PlayerStats.maxPlayerHealth}",40, 5, 20, WHITE);
        
        
    }

    public static void DrawColliderBox(Character character)
    {
        DrawRectangleLines(character.x + character.GetOffsetColliderWidth() / 2,
            character.y + character.GetOffsetColliderHeight() / 2, character.GetColliderBoxWidth(),
            character.GetColliderBoxHeight(), GREEN);
    }

    public static void DrawPowerUpShield()
    {
        if (Powerup.effectTime > 0 && Powerup.isShielded)
        {
            DrawText(Convert.ToInt32(Math.Floor(Powerup.effectTime)).ToString(), 60, 48, 30, WHITE);
            DrawTexture(ImageService.powerUpShieldTexture, 5, 35, WHITE);
        }
    }

    public static void DrawPowerUpRicochet()
    {
        if (Powerup.effectTime > 0 && Powerup.isExplosiveShot)
        {
            DrawText(Convert.ToInt32(Math.Floor(Powerup.effectTime)).ToString(), 60, 48, 30, WHITE);
            DrawTexture(ImageService.powerUpRicochetTexture, 5, 35, WHITE);
        }
    }

    public static void DrawPowerUpHit1()
    {
        if (Powerup.effectTime > 0 && Powerup.isHealthHit1)
        {
            DrawTexture(ImageService.healthHit1Texture, 5, 35, WHITE);
        }
    }

    public static void DrawPowerUpHit2()
    {
        if (Powerup.effectTime > 0 && Powerup.isHealthhit2)
        {
            DrawTexture(ImageService.healthHit2Texture, 5, 35, WHITE);
        }
    }

    public static void DrawPowerUpRestoreHealth()
    {
        if (Powerup.effectTime > 0 && Powerup.isRestoredHealth)
        {
            DrawTexture(ImageService.powerUpHealthTexture, 5, 35, WHITE);
        }
    }

    public static void DrawPowerUpCoin()
    {
        if (Powerup.effectTime > 0 && Powerup.isCoins)
        {
            DrawTexture(ImageService.getCoinTexture, 5, 35, WHITE);
        }
    }
    

    public static void DrawWaveText()
    {
        DrawText($"{Convert.ToInt32(DifficultyHandler.currentLevel * Director.levelTime - Director.secondsPassed)}", 1350, 5, 20, WHITE);
        DrawText("Next Wave In:",1200,5,20,WHITE);
    }

    public static void DrawlevelText()
    {
        DrawText($"{DifficultyHandler.currentLevel}", 1350, 30, 20, WHITE);
        DrawText("Level:",1280,30,20,WHITE);
    }
}