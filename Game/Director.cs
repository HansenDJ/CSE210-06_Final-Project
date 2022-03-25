using System;
using Raylib_cs;
using System.Timers;

namespace generalNamespace;

public class Director
{
    private static System.Timers.Timer timer;
    // Number of milliseconds between frames
    int updateFrameTime = 5;
    private static int reloadTime = 0;
    static bool action = false;
    public void StartGame()
    {
        Raylib.InitWindow(VideoService.scrnWidth, VideoService.scrnHeight, "FLUX");
        SetTimer(updateFrameTime);
        VideoService vd= new();
        Player player = new();
        SpawnDestory sp = new SpawnDestory();
        player.SetTexture(ImageService.SetShipStartImage());
        player.SetPlayerStats();
        player.SetPlayerXY(player);
        BackgroundService bg = new BackgroundService();
        bg.SetTexture(ImageService.SetEarthBGStartImage(),ImageService.SetEarthBGStartImage());
        Coin coin = new Coin();
        coin.SetTexture(ImageService.SetCoinGif());
        
        // // TEST
        // Random rnd = new Random();

       
      
        while (!Raylib.WindowShouldClose())
        {
            
            if (action)
            {
                
                DifficultyHandler.incrementHandler();
                // // TEST
                // updateFrameTime = 20;
                // VideoService.scrnWidth = rnd.Next(1000, 1401);
                // VideoService.scrnHeight = rnd.Next(600, 851);
                // Raylib.SetWindowSize(VideoService.scrnWidth, VideoService.scrnHeight);
                // updateFrameTime = 5;

                reloadTime += 20;
                Raylib.BeginDrawing();
                bg.ServeBackgrounds();
                if (sp.CheckIfSpawnNeeded()) {
                    sp.SpawnEnemy(4);     // Create method in Level.cs to choose which enemy to spawn based on level number
                }
                sp.EntityListLoop(player);
              
                
                sp.MakeWeaponsMove();
                VideoService.Draw(sp.GetEntities(),sp.getWeapons(),player);
                vd.DrawPlayer(player);
                VideoService.DrawColliderBox(player);  // Draws collider box around player
                vd.DrawCoinCount(coin);
                
                if (player.PlayerMoveKeys() == 1)
                {
                    if (reloadTime >= 1200)
                    {
                        sp.SpawnWeapon('1',player,ImageService.SetLaser1Image()) ;
                        reloadTime = 0;
                    }
                }
                sp.MakeWeaponsMove();
                VideoService.Draw(sp.GetEntities(),sp.getWeapons(), player,bg);
                vd.DrawPlayer(player);
                VideoService.DrawColliderBox(player);  // Draws collider box around player
                // Add assert make sure player horizontal speed is less than laser movement speed so he doesn't pass his bullets
                Raylib.EndDrawing();
                action = false;
            }
            
        }
    }

    // Change updateFrameTime variable above to change number of milliseconds between frames
    static void SetTimer(int frameTime) {
        timer = new System.Timers.Timer(frameTime);

        timer.Elapsed += OnTimedEvent;
        timer.AutoReset = true;
        timer.Enabled = true;
    }

    static void OnTimedEvent(Object source, ElapsedEventArgs e) {
        action = true;
    }
}