using System;
using System.Net;
using System.Windows;
using generalNamespace.Laser;
using Raylib_cs;
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

    public static void Draw(List<Enemy> objectsToDraw, List<Weapon> weaponsToDraw,Player player,BackgroundService bg, Coin coin,List<Weapon> EnemyWeaponsToDraw)
    {
        DrawBackdrop(bg);
        DrawCoinCount(coin);
        DrawHeartCount();
        DrawEnemies(objectsToDraw,weaponsToDraw,player,EnemyWeaponsToDraw);
        DrawShip();
    }

    private static void DrawBackdrop(BackgroundService bg)
    {
        Raylib.ClearBackground(Raylib_cs.Color.BLACK);
        DrawTexture(bg.bg1Texture,bg.x1,bg.y1,WHITE);
        DrawTexture(bg.bg2Texture,bg.x2,bg.y2,WHITE);
    }

    private static void DrawEnemies(List<Enemy> objectsToDraw,List<Weapon> weaponsToDraw,Player player,List<Weapon> EnemyWeaponsToDraw)
    {
        Console.WriteLine( "Object Count: " + objectsToDraw.Count().ToString() + " Weapon Count: " + weaponsToDraw.Count().ToString());
        for (int i = 0; i < objectsToDraw.Count - 1; i++)
        {
            DrawEnemy(objectsToDraw[i]);
            DrawColliderBox(objectsToDraw[i]);
        }
        for (int i = 0; i < weaponsToDraw.Count - 1; i++)
        {
            if (!weaponsToDraw[i].location)
            {
                weaponsToDraw[i].offsetW = 5;
                weaponsToDraw[i].offsetW = 10;
                weaponsToDraw[i].SetOffsetColliderWidth(player.offsetW);
                weaponsToDraw[i].SetOffsetColliderHeight(player.offsetH);
                weaponsToDraw[i].SetX(player.x + player.GetColliderBoxWidth());
                weaponsToDraw[i].SetY(player.y + player.GetColliderBoxHeight() / 2);
                weaponsToDraw[i].location = true;
                {
                    
                }
            }
            DrawEnemy(weaponsToDraw[i]);
            DrawColliderBox(weaponsToDraw[i]);
        }
        for (int i = 0; i < EnemyWeaponsToDraw.Count - 1; i++)
        {
           // if (!EnemyWeaponsToDraw[i].location)
           // {
                //EnemyWeaponsToDraw[i].offsetW = 5;
              //  EnemyWeaponsToDraw[i].offsetW = 10;
              //  EnemyWeaponsToDraw[i].SetOffsetColliderWidth(player.offsetW);
              //  EnemyWeaponsToDraw[i].SetOffsetColliderHeight(player.offsetH);
              //  EnemyWeaponsToDraw[i].SetX(player.x + player.GetColliderBoxWidth());
             //  EnemyWeaponsToDraw[i].SetY(player.y + player.GetColliderBoxHeight() / 2);
             //   EnemyWeaponsToDraw[i].location = true;
              
           // }
            DrawEnemy(EnemyWeaponsToDraw[i]);
            DrawColliderBox(EnemyWeaponsToDraw[i]);
        }
    }
    
    public static void DrawEnemy(Character enemy) // draws an artifact
    {
        DrawTexture(enemy.charTexture, enemy.x, enemy.y, WHITE);
    }

    private static void DrawShip()
    {

    }

    public void DrawPlayer(Player player)
    {
        DrawTexture(player.charTexture, player.x, player.y, WHITE);
        DrawTexture(player.charTexture, player.x, player.y, WHITE);
    }

    public static void DrawCoinCount(Coin coin)
    {
        Raylib.DrawText("coincount", 1250,22,20,WHITE);
         DrawTexture(coin.charTexture,1220,20,WHITE);
    }
    public static void DrawHeartCount()
    {
        Raylib.DrawText($"{PlayerStats.playerHealth}/{PlayerStats.maxPlayerHealth}", 30,22,20,WHITE);
    }

    public static void DrawColliderBox(Character character)
    {
        DrawRectangleLines(character.x + character.GetOffsetColliderWidth() / 2, character.y + character.GetOffsetColliderHeight() / 2, character.GetColliderBoxWidth(), character.GetColliderBoxHeight(), GREEN);
    }

    
}