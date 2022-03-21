using System;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Raylib_cs.Color;
namespace generalNamespace;

public class VideoService
{
    public static int scrnWidth = 1400;
    public static int scrnHeight = 900;

    public static void Draw(List<Enemy> objectsToDraw)
    {
        DrawBackdrop();
        DrawEntities(objectsToDraw);
        DrawShip();
    }

    private static void DrawBackdrop()
    {
        Raylib.ClearBackground(Raylib_cs.Color.BLACK);
    }

    private static void DrawEntities(List<Enemy> objectsToDraw)
    {
        for (int i = 0; i < objectsToDraw.Count; i ++) {
            DrawEnemy(objectsToDraw[i]);
        }
    }
    public static void DrawEnemy(Enemy enemy) // draws an artifact
    {
        DrawTexture(LoadTextureFromImage(enemy.charImage), enemy.x, enemy.y, WHITE);
        
    }

    private static void DrawShip()
    {
        
    }

    public void DrawPlayer(Player player)
    {
        
       // DrawCircle(player.x,player.y,player.radius,WHITE);
        DrawTexture(LoadTextureFromImage(player.charImage), player.x, player.y, WHITE);
       // DrawRectangle(player.x,player.y,370,370,WHITE);
        
        

    }


}