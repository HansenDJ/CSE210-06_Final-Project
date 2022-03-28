using System;
using Raylib_cs;
using System.Timers;

namespace generalNamespace;

public class Director
{
    // private static System.Timers.Timer timer;
    // Number of milliseconds between frames
    // int updateFrameTime = 5;
    public static int playerHealth = 50;
    public static int maxPlayerHealth = 50;
    private static int reloadTime = 0;
    // static bool action = false;
    public void StartGame()
    {
        Raylib.InitWindow(VideoService.scrnWidth, VideoService.scrnHeight, "FLUX");
        ExplosionService.LoadAnimation();
        Timer timer = new();
        // SetTimer(updateFrameTime);
        VideoService vd = new();
        // AudioService audioService = new();
        Player player = new();
        SpawnDestory sp = new SpawnDestory();
        player.SetTexture(ImageService.SetShipStartImage());
        player.SetPlayerStats();
        player.SetPlayerXY(player);
        BackgroundService bg = new BackgroundService();
        bg.SetTexture(ImageService.SetEarthBGStartImage());
        Coin coin = new Coin();
        coin.SetTexture(ImageService.SetCoinGif());
       



        while (!Raylib.WindowShouldClose())
        {
            // INPUT
            if (sp.CheckIfSpawnNeeded()) {
                sp.SpawnEnemy(1);     // Create method in difficultyHandler.cs to choose which enemy to spawn based on level number
            }
            // audioService.LoadAudio(audioService.soundBattleLv1);

            // UPDATES
            timer.Count();
            // if (action)
            while(timer.CheckLagging())
            {
                if (DifficultyHandler.levelChange)
                {
                    DifficultyHandler.levelChange = false;
                    switch (DifficultyHandler.level)
                    {
                        case 2:
                            bg.SetTexture(ImageService.SetWaterBGStartImage());
                            break;
                        case 3:
                            bg.SetTexture(ImageService.SetAirBGStartImage());
                            break;
                        case 4:
                            bg.SetTexture(ImageService.SetFireBGStartImage());
                            break;
                        case 5:
                            bg.SetTexture(ImageService.SetShadowBGStartImage());
                            break;
                    }
                   
                }
                DifficultyHandler.incrementHandler();

                if (player.PlayerMoveKeys() == 1)
                {
                    if (reloadTime >= 200)
                    {
                        sp.SpawnWeapon('1',player,ImageService.SetLaser1Image());
                        reloadTime = 0;
                    }
                }

                reloadTime += 20;
                sp.EntityListLoop(player);
                
                sp.MakeWeaponsMove();
                sp.MakeEnemyWeaponsMove(player);
                
                timer.RealTime();

                // OUTPUT
                Raylib.BeginDrawing();
                bg.ServeBackgrounds();
                VideoService.Draw(sp.GetEntities(),sp.getWeapons(), player,bg, coin,sp.getEnemyWeapons());
                vd.DrawPlayer(player);
                VideoService.DrawColliderBox(player);  // Draws collider box around player
                // Add assert make sure player horizontal speed is less than laser movement speed so he doesn't pass his bullets
                Raylib.EndDrawing();
            //     action = false;
            }
            
        }
        // audioService.UnloadAudio(audioService.soundBattleLv1);
        // audioService.CloseAudio();
    }

    // // Change updateFrameTime variable above to change number of milliseconds between frames
    // static void SetTimer(int frameTime) {
    //     timer = new System.Timers.Timer(frameTime);

    //     timer.Elapsed += OnTimedEvent;
    //     timer.AutoReset = true;
    //     timer.Enabled = true;
    // }

    // static void OnTimedEvent(Object source, ElapsedEventArgs e) {
    //     action = true;
    // }
}