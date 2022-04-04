using CSE210_06_Final_Project;
using Raylib_cs;

namespace generalNamespace;

public class Director
{
    // private static System.Timers.Timer timer;
    // Number of milliseconds between frames
    // int updateFrameTime = 5;

    // public static bool unloadCheck = false;
    // static bool action = false;f
   public static double secondsPassed = 0;
   public static Double levelTime = 90;
   public static bool pause = false;
   public static bool dead1st = true;
    public void StartGame()
    {
       
        var startTime = DateTime.Now;
        var timeNow = DateTime.Now;
       
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
        CurrencyHandler.money = 100;
        while (!Raylib.WindowShouldClose())
        {
       
            // INPUT
            SpawnCheck(sp);
            // UPDATES
            startTime = CheckIfDied(timer, startTime, bg, sp, coin);
            TimeService(startTime, sp);
            // if (action)
            LevelChangeCheck(bg);
            Powerup.ReduceEffectTime();

            TimerCheckLagandDraw(timer, player, sp, bg, coin);
        }

       

        ImageService.UnloadAllTextures();
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
          
            
            //AudioService.UnloadAudio();
            if (KeyboardService.RKeyReleased())
            {
              
                timer.previousReset();
                timer.Count();
                startTime = DateTime.Now;
                secondsPassed = 0;
                DifficultyHandler.levelChange = true;
                DifficultyHandler.currentLevel = 1;
                DifficultyHandler.previousLevel = 1;
                PlayerStats.maxPlayerHealth = 300;
                PlayerStats.playerHealth = PlayerStats.maxPlayerHealth;

                LevelChangeCheck(bg);

                DifficultyHandler.enemyCount = 3;
                Powerup.effectTime = 0;
                Powerup.endTime = 0;
                Powerup.isShielded = false;
                Powerup.isExplosiveShot = false;

                CurrencyHandler.money = 0;
                sp.ClearMap();
               





            }

        }

        return startTime;
    }

    private static void TimerCheckLagandDraw(Timer timer, Player player, SpawnDestory sp, BackgroundService bg, Coin coin)
    {
        while (timer.CheckLagging())
        {
            if (player.PlayerMoveKeys() == 1) //When spacebar pressed
                sp.ShootWeapon(player);
            if (KeyboardService.TabKeyReleased())
            {
                if (CurrencyHandler.money >= 100)
                {
                    CurrencyHandler.money -= 100;
                    PlayerStats.playerHealth += 50;
                    if (PlayerStats.playerHealth > PlayerStats.maxPlayerHealth)
                    {
                        PlayerStats.playerHealth = PlayerStats.maxPlayerHealth;
                    }
                }
            }else if (KeyboardService.ShiftReleased())
            {
                if (CurrencyHandler.money >=50)
                {
                    CurrencyHandler.money -= 50;
                    Powerup.randomEffect();
                   
                }
            }

            if (Raylib.IsKeyReleased(KeyboardKey.KEY_P))
            {
                pause = !pause;
            }


            sp.IncrementReloadTime();

            timer.RealTime();

            // OUTPUT
            Raylib.BeginDrawing();

            bg.ServeBackgrounds();

            VideoService.DrawBackdrop(bg);
            if (SpawnBoss.timeForBoss)
            {
                SpawnBoss.timeForBoss = false;
                sp.SpawnBoss(DifficultyHandler.currentLevel);
            }

            
            VideoService.Draw(sp.GetEnemies(), sp.getPlayerWeapons(), player, bg, coin,
                sp.getExplosions(), sp.GetPowerUps());
                
            sp.EnemyListLoop(player);
            sp.MakeEnemyWeaponsMove(player);
            sp.MakePlayerWeaponsMove();
            sp.PowerUpFall(player);

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
        timeNow = DateTime.Now;
        secondsPassed = (timeNow - startTime).TotalSeconds;
        if (DifficultyHandler.LevelUp(secondsPassed / Director.levelTime)) sp.maxEnemies = DifficultyHandler.enemyCount;
    }
    
    private static void SpawnCheck(SpawnDestory sp)
    {
        if (secondsPassed > BackgroundService.movefast)
        {
            // Choose which enemy to spawn based on level number
            if (sp.CheckIfSpawnNeeded())sp.SpawnEnemy(DifficultyHandler.currentLevel);
        }
       
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