using System;
using Raylib_cs;

namespace generalNamespace;

public class Director
{
    public void StartGame()
    {
        Raylib.InitWindow(VideoService.scrnWidth, VideoService.scrnHeight, "FLUX");
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            VideoService.Draw();
            
            
            Raylib.EndDrawing();
        }
    }
}