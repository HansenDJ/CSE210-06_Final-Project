using System;
using Raylib_cs;

namespace generalNamespace;

public class Director
{
    public void startGame()
    {
        Raylib.InitWindow(1000, 1000, "FLUX");
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            VideoService.draw();
            
            
            Raylib.EndDrawing();
        }
    }
}