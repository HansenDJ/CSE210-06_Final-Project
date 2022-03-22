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
        Raylib.InitWindow(VideoService.scrnWidth, VideoService.scrnHeight, "FLUX");
        SetTimer();
        VideoService vd= new();
        Player player = new();
        SpawnDestory sp = new SpawnDestory();
        player.SetImage(ImageService.SetShipStartImage());
        player.SetPlayerStats();
        player.SetPlayerXY(player);

       
      
        while (!Raylib.WindowShouldClose())
        {
            
            if (action)
            {
                Raylib.BeginDrawing();
                if (sp.CheckIfSpawnNeeded()) {
                    sp.SpawnEnemy('1');
                }
                sp.EntityListLoop(player);
                player.PlayerMoveKeys();
                VideoService.Draw(sp.GetEntities());
                vd.DrawPlayer(player);
                VideoService.DrawColliderBox(player);  // Draws collider box around player
                Raylib.EndDrawing();
                action = false;
            }
            
        }
    }
    static void SetTimer() {
        timer = new System.Timers.Timer(15);

        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    static void OnTimedEvent(Object source, ElapsedEventArgs e) {
        action = true;
    }
}