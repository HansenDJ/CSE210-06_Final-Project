using System;
using Raylib_cs;
using System.Timers;
namespace generalNamespace;

public class Director
{
    private static System.Timers.Timer timer;
    static bool action = false;
    public void StartGame()
    {
        VideoService vd= new();
        Player player = new();

        Raylib.InitWindow(VideoService.scrnWidth, VideoService.scrnHeight, "FLUX");
      
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            VideoService.Draw();
            vd.DrawPlayer(player);
            
            Raylib.EndDrawing();
        }
    }
    static void SetTimer() {
        timer = new System.Timers.Timer(20);

        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    static void OnTimedEvent(Object source, ElapsedEventArgs e) {
        action = true;
    }
}