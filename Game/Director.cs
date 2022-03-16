using System;
using Raylib_cs;

namespace generalNamespace;

public class Director
{
    public void startGame()
    {
        Raylib.InitWindow(VideoService.scrnWidth, VideoService.scrnHeight, "FLUX");
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            VideoService.draw();
            
            
            Raylib.EndDrawing();
        }
    }
}