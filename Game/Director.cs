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
        SetTimer();
        VideoService vd= new();
        Player player = new();
        player.SetImage(ImageService.SetShipStartImage());
        player.SetRadius(10);

        Raylib.InitWindow(VideoService.scrnWidth, VideoService.scrnHeight, "FLUX");
      
        while (!Raylib.WindowShouldClose())
        {
            
            if (action)
            {
                Raylib.BeginDrawing();
                if (KeyboardService.WKeyDown())
                {
                    player.y -= player.GetPlayerMovementSpeed();
                }else if (KeyboardService.SKeyDown())
                {
                    player.y += player.GetPlayerMovementSpeed();
                }
                VideoService.Draw();
                vd.DrawPlayer(player);
                Raylib.EndDrawing();
                action = false;
            }
            
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