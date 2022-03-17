using System;
using Raylib_cs;
using static Raylib_cs.Raylib;
using System.Collections.Generic;

namespace generalNamespace;

public class RaylibVideoService
{
    public void DrawPlayer(Player player)
    {
   
        Raylib.DrawCircle(player.playerX, player.playerY, player.playerRadius, Color.RED);
    
    }
}