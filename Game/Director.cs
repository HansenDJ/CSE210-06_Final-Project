using System;
using Raylib_cs;

namespace generalNamespace;

public class Director
{
    private int fps;
    public void StartGame()
    {
        RaylibVideoService raylibvs = new();
        Player player = new();

        Raylib.InitWindow(VideoService.scrnWidth, VideoService.scrnHeight, "FLUX");
        SetFPS();
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            VideoService.Draw();
            raylibvs.DrawPlayer(player);
            
            Raylib.EndDrawing();
        }
    }
    public void SetFPS(int fps = 60) {
        this.fps = fps;
        Raylib.SetTargetFPS(fps);
    }
}