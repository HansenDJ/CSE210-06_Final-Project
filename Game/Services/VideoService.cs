using System;
using generalNamespace.Laser;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;

namespace generalNamespace;

public class VideoService
{
    public static int scrnWidth = 1400;
    public static int scrnHeight = 900;

    public static void Draw(List<Enemy> objectsToDraw, List<Weapon> weaponsToDraw)
    {
        DrawBackdrop();
        DrawEntities(objectsToDraw,weaponsToDraw);
        DrawShip();
    }

    private static void DrawBackdrop()
    {
        Raylib.ClearBackground(Raylib_cs.Color.BLACK);
    }

    /* QUESTION: Should end be -1 or not?
    -------------------------------------
    -----------------------------------*/
    private static void DrawEntities(List<Enemy> objectsToDraw,List<Weapon> weaponsToDraw)
    {
        Console.WriteLine( "Object Count: " + objectsToDraw.Count().ToString() + "Weapon Count" + weaponsToDraw.Count().ToString());
        for (int i = 0; i < objectsToDraw.Count - 1; i++)
        {
            DrawEntity(objectsToDraw[i]);
            DrawColliderBox(objectsToDraw[i]);
        }
        for (int i = 0; i < weaponsToDraw.Count - 1; i++)
        {
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

    public void DrawCoinCount()
    {

    }
    public void DrawHeartCount()
    {

    }

    public static void DrawColliderBox(Character character)
    {
          DrawRectangleLines(character.x + character.offsetWidth / 2, character.y + character.offsetHeight / 2, character.GetImageWidth() - character.offsetWidth, character.GetImageHeight() - character.offsetHeight, GREEN);
    }
}