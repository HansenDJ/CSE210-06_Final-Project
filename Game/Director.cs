using System;
using Raylib_cs;
using System.Timers;
namespace generalNamespace;

public class Director
{
    private static System.Timers.Timer timer;
    private static int reloadTime = 0;
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
                reloadTime += 20;
                Raylib.BeginDrawing();
                if (sp.CheckIfSpawnNeeded()) {
                    sp.SpawnEnemy('1');
                }
                sp.EntityListLoop(player);
              
                if (player.PlayerMoveKeys() == 1)
                {
                    if (reloadTime >= 400)
                    {
                        sp.SpawnWeapon('1',player,ImageService.SetLaser1Image()) ;
                        reloadTime = 0;
                    }
                } 
                sp.MakeWeaponsMove();
                VideoService.Draw(sp.GetEntities(),sp.getWeapons());
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