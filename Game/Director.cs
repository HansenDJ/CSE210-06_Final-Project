using CSE210_06_Final_Project;
using Raylib_cs;

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
        var startTime = DateTime.Now;
        var timeNow = DateTime.Now;
        double secondsPassed = 0;
        ImageService.LoadAllImages();
        ImageService.LoadAllTextures();
        ImageService.LoadExplosionAnimation();
        ImageService.UnloadAllImages();
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
            SpawnCheck(sp);
            // UPDATES
            startTime = CheckIfDied(timer, startTime, bg, sp, coin);
            TimeService(startTime, sp);
            // if (action)
            LevelChangeCheck(bg);

            TimerCheckLagandDraw(timer, player, sp, bg, coin);
        }

        AudioService.UnloadAudio(AudioService.lv1Shot); // Unload this shot sound when a player switches weapons
        AudioService.CloseAudio();
    }

    private static DateTime CheckIfDied(Timer timer, DateTime startTime, BackgroundService bg, SpawnDestory sp, Coin coin)
    {
        if (!PlayerStats.PlayerDeadCheck())
        {
            timer.Count();
        }
        else
        {
            GameOverDeath.loadScreen();
            if (KeyboardService.SpaceKeyDown())
                startTime = RestartLevel(bg, timer, sp, coin);
            //
        }

        return startTime;
    }

    private static void TimerCheckLagandDraw(Timer timer, Player player, SpawnDestory sp, BackgroundService bg, Coin coin)
    {
        while (timer.CheckLagging())
        {
            if (player.PlayerMoveKeys() == 1) //When spacebar pressed
                sp.ShootWeapon(player);


            sp.IncrementReloadTime();
            sp.EnemyListLoop(player);

            sp.MakePlayerWeaponsMove();
            sp.MakeEnemyWeaponsMove(player);

            timer.RealTime();

            // OUTPUT
            Raylib.BeginDrawing();

            bg.ServeBackgrounds();
            VideoService.Draw(sp.GetEnemies(), sp.getPlayerWeapons(), player, bg, coin, sp.getEnemyWeapons(),
                sp.getExplosions());
            VideoService.DrawColliderBox(player); // Draws collider box around player
            // Add assert make sure player horizontal speed is less than laser movement speed so he doesn't pass his bullets
            Raylib.EndDrawing();
            //     action = false;
            // if(unloadCheck == false)
            // {
            //     ImageService.UnloadAllImages();
            // }
        }
    }

    private static void TimeService(DateTime startTime, SpawnDestory sp)
    {
        DateTime timeNow;
        double secondsPassed;
        timeNow = DateTime.Now;
        secondsPassed = (timeNow - startTime).TotalSeconds;

        if (DifficultyHandler.LevelUp(secondsPassed / 30D)) sp.maxEnemies = DifficultyHandler.enemyCount;
    }

    private static void SpawnCheck(SpawnDestory sp)
    {
        if (sp.CheckIfSpawnNeeded())
            sp.SpawnEnemy(DifficultyHandler
                .currentLevel); // Create method in difficultyHandler.cs to choose which enemy to spawn based on level number
    }

    private static void LevelChangeCheck(BackgroundService bg)
    {
        if (DifficultyHandler.levelChange)
        {
            DifficultyHandler.levelChange = false;
            switch (DifficultyHandler.currentLevel)
            {
                case 1:
                   
                    bg.LoadBGTexture(ImageService.earthBGStartTexture);
                    break;
                case 2:
                  
                    bg.LoadBGTexture(ImageService.waterBGStartTexture);
            
                    break;
                case 3:
                    
                    bg.LoadBGTexture(ImageService.airBGStartTexture);
                  
                    break;
                case 4:
                   
                    bg.LoadBGTexture(ImageService.fireBGStartTexture);
                    
                    break;
                case 5:
                    
                    bg.LoadBGTexture(ImageService.shadowBGStartTexture);
                   
                    break;
            }
        }
    }

    private static DateTime RestartLevel(BackgroundService bg, Timer timer, SpawnDestory sp, Coin coin)
    {
        DateTime startTime;
        DateTime timeNow;
        double secondsPassed;
        timer.Count();
       
        PlayerStats.playerHealth = PlayerStats.maxPlayerHealth;
        DifficultyHandler.levelChange = true;
        DifficultyHandler.currentLevel = 1;
        DifficultyHandler.previousLevel = 1;
        LevelChangeCheck(bg);
      
        DifficultyHandler.enemyCount = 3;
       
        coin.CoinCount = 0;
        sp.ClearMap();

        startTime = DateTime.Now;
        timeNow = DateTime.Now;
        secondsPassed = 0;
        return startTime;
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