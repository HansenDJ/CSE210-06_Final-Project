using System;
using Raylib_cs;

namespace generalNamespace;

public class Director
{
    public void StartGame()
    {
        RaylibVideoService raylibvs = new();
        Player player = new();

        Raylib.InitWindow(VideoService.scrnWidth, VideoService.scrnHeight, "FLUX");
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            VideoService.Draw();
            raylibvs.DrawPlayer(player);
            
            Raylib.EndDrawing();
        }
    }
}