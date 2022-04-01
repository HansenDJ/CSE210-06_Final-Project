using System;
using Raylib_cs;
using System.Timers;
using CSE210_06_Final_Project;

namespace generalNamespace;

public class Director
{
    // private static System.Timers.Timer timer;
    // Number of milliseconds between frames
    // int updateFrameTime = 5;

    // public static bool unloadCheck = false;
    // static bool action = false;
    public void StartGame()
    {
        DateTime startTime = DateTime.Now;
        DateTime timeNow = DateTime.Now;
        double secondsPassed = 0;
        ImageService.LoadAllImages();
        ImageService.LoadAllTextures();
        ImageService.LoadExplosionAnimation();
        // Raylib.SetTargetFPS(60); // TRY TO USE INSTEAD OF TIMER
        Timer timer = new();
        // SetTimer(updateFrameTime);
        VideoService vd = new();
        BackgroundService bg = new();
        Player player = new();
        SpawnDestory sp = new();
        Coin coin = new();
        // player.SetTexture(ImageService.SetShipStartImage());
        bg.LoadBGTexture(ImageService.earthBGStartTexture);
        player.SetCharTexture(ImageService.startShipTexture);
        player.SetPlayerStats();
        player.SetPlayerXY(player);
        // coin.SetTexture(ImageService.SetCoinGif());
        AudioService.InitSound();
        AudioService.LoadAudio(AudioService.lv1Shot);


        while (!Raylib.WindowShouldClose())
        {
              
            // INPUT
            if (sp.CheckIfSpawnNeeded()) {
                sp.SpawnEnemy(DifficultyHandler.currentLevel);     // Create method in difficultyHandler.cs to choose which enemy to spawn based on level number
            }

            // UPDATES
            if (!PlayerStats.PlayerDeadCheck())
            {
                timer.Count();
            }
            else
            {
                GameOverDeath.loadScreen();
                if (KeyboardService.SpaceKeyDown())
                {
                    bg.LoadBGTexture(ImageService.earthBGStartTexture);
                    timer.Count();
                    PlayerStats.playerHealth = 50;
                    DifficultyHandler.currentLevel = 1;
                    DifficultyHandler.previousLevel = 1;
                    DifficultyHandler.enemyCount = 3;
                  
                     startTime = DateTime.Now;
                    timeNow = DateTime.Now;
                    secondsPassed = 0;

                }
            }
           
          //  if(PlayerStats.PlayerDeadCheck()) {
           //     timer.TIME_STEP = 0;

            //      break;
            //  }
            

            timeNow = DateTime.Now;
            secondsPassed = (timeNow - startTime).TotalSeconds;

            if (DifficultyHandler.LevelUp(secondsPassed / 30D))
            {
                sp.maxEnemies = DifficultyHandler.enemyCount;
                
            }
            
            
            // if (action)
            if (DifficultyHandler.levelChange)
            {
                DifficultyHandler.levelChange = false;
                switch (DifficultyHandler.currentLevel)
                {
                    case 2:
                        BackgroundService.previousBGTexture = BackgroundService.currentBGTexture;
                        bg.LoadBGTexture(ImageService.waterBGStartTexture);
                        ImageService.UnloadTextureFile(BackgroundService.previousBGTexture);
                        break;
                    case 3:
                        BackgroundService.previousBGTexture = BackgroundService.currentBGTexture;
                        bg.LoadBGTexture(ImageService.airBGStartTexture);
                        ImageService.UnloadTextureFile(BackgroundService.previousBGTexture);
                        break;
                    case 4:
                        BackgroundService.previousBGTexture = BackgroundService.currentBGTexture;
                        bg.LoadBGTexture(ImageService.fireBGStartTexture);
                        ImageService.UnloadTextureFile(BackgroundService.previousBGTexture);
                        break;
                    case 5:
                        BackgroundService.previousBGTexture = BackgroundService.currentBGTexture;
                        bg.LoadBGTexture(ImageService.shadowBGStartTexture);
                        ImageService.UnloadTextureFile(BackgroundService.previousBGTexture);
                        break;
                }
                
            }
           
            while(timer.CheckLagging())
            {
                if (player.PlayerMoveKeys() == 1) //When spacebar pressed
                {
                    sp.ShootWeapon(player);
                }
                

                sp.IncrementReloadTime();
                sp.EnemyListLoop(player);
                
                sp.MakePlayerWeaponsMove();
                sp.MakeEnemyWeaponsMove(player);
                
                timer.RealTime();

                // OUTPUT
                Raylib.BeginDrawing();
                
                bg.ServeBackgrounds();
                VideoService.Draw(sp.GetEnemies(),sp.getPlayerWeapons(), player,bg, coin,sp.getEnemyWeapons(),sp.getExplosions());
                VideoService.DrawColliderBox(player);  // Draws collider box around player
                // Add assert make sure player horizontal speed is less than laser movement speed so he doesn't pass his bullets
                Raylib.EndDrawing();
            //     action = false;
                // if(unloadCheck == false)
                // {
                //     ImageService.UnloadAllImages();
                // }
            }
        }
        AudioService.UnloadAudio(AudioService.lv1Shot); // Unload this shot sound when a player switches weapons
        AudioService.CloseAudio();
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