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

    public static void Draw(List<Enemy> objectsToDraw, List<Weapon> weaponsToDraw,Player player,BackgroundService bg, Coin coin)
    {
        DrawBackdrop(bg);
        DrawCoinCount(coin);
        DrawEntities(objectsToDraw,weaponsToDraw,player);
        DrawShip();
    }

    private static void DrawBackdrop(BackgroundService bg)
    {
        Raylib.ClearBackground(Raylib_cs.Color.BLACK);
        DrawTexture(bg.bg1Texture,bg.x1,bg.y1,WHITE);
        DrawTexture(bg.bg2Texture,bg.x2,bg.y2,WHITE);
    }

    /* QUESTION: Should end be -1 or not?
    -------------------------------------
    -----------------------------------*/
    private static void DrawEntities(List<Enemy> objectsToDraw,List<Weapon> weaponsToDraw,Player player)
    {
        Console.WriteLine( "Object Count: " + objectsToDraw.Count().ToString() + "Weapon Count" + weaponsToDraw.Count().ToString());
        for (int i = 0; i < objectsToDraw.Count - 1; i++)
        {
            DrawEntity(objectsToDraw[i]);
            DrawColliderBox(objectsToDraw[i]);
        }
        for (int i = 0; i < weaponsToDraw.Count - 1; i++)
        {
            if (!weaponsToDraw[i].location)
            {
                weaponsToDraw[i].SetX(player.x);
                weaponsToDraw[i].SetY(player.y);
                weaponsToDraw[i].location = true;
                {
                    
                }
            }
            DrawEntity(weaponsToDraw[i]);
            DrawColliderBox(weaponsToDraw[i]);
        }
    }
    
    public static void DrawEntity(Character entity) // draws an artifact
    {
        DrawTexture(entity.charTexture, entity.x, entity.y, WHITE);
    }

    private static void DrawShip()
    {

    }

    public void DrawPlayer(Player player)
    {
        
        DrawTexture(player.charTexture, player.x, player.y, WHITE);
    }

    public static void DrawCoinCount(Coin coin)
    {
        Raylib.DrawText("coincount", 1250,22,20,WHITE);
         DrawTexture(coin.charTexture,1220,20,WHITE);
    }
    public void DrawHeartCount()
    {

    }

    public static void DrawColliderBox(Character character)
    {
        DrawRectangleLines(character.x + character.GetOffsetColliderWidth() / 2, character.y + character.GetOffsetColliderHeight() / 2, character.GetColliderBoxWidth(), character.GetColliderBoxHeight(), GREEN);
    }

    
}