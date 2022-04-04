namespace generalNamespace;

public static class DifficultyHandler
{
    public static int difficultyHandler = 0;
    public static int enemyCount = 3;
    public static int currentLevel = 1;
    public static int previousLevel = 1;
    public static bool levelChange;

    public static int maxEnemies = 50;
    //public static bool newAudio = true;


  

    public static bool LevelUp(double time)
    {
      
       // if (Director.dead1st)
     //   {
       //     newAudio = true;
       //     Director.dead1st = false;
   //     }
       
        var lvl = Convert.ToInt32(Math.Floor(time));
        currentLevel = 1 + lvl;
       // if (newAudio)
      //  {
     //       AudioPlayer();
       //     newAudio = false;
     //   }
        if (currentLevel > previousLevel)
        {
           AudioService.PlayAudio(AudioService.bossSpawn);
            IncreaseDifficulty();
            PlayerStats.maxPlayerHealth += 50;
            // do level changes here;
            previousLevel = currentLevel;
            Console.WriteLine("Level UP " + currentLevel);
            levelChange = true;
            SpawnBoss.timeForBoss = true;
            //newAudio = true;
            return true;
        }

        return false;
    }

    public static void AudioPlayer()
    {
        switch (currentLevel)
        {
            case 1:
                AudioService.PlayAudioBackground(AudioService.battlelv1);
                break;
            case 2:
                AudioService.PlayAudioBackground(AudioService.battlelv2);
                break;
            case 3:
                AudioService.PlayAudioBackground(AudioService.battlelv3);
                break;
                case 4:
                    
                    AudioService.PlayAudioBackground(AudioService.battlelv4);
                    break;
                    
                     default :
                      
                        AudioService.PlayAudioBackground(AudioService.battlelv5);
                        break;
        }

        
           
       
   
    }

    public static int GetEnemyLevel()
    {
        var difficulty = 1;
        var rnd = new Random();
        difficulty = rnd.Next(1, 3);
        return difficulty;
    }

    private static Random rnd = new Random();
    public static void IncreaseDifficulty()
    {
        if (enemyCount < maxEnemies)
        {
            enemyCount += rnd.Next(1,5);
            
        }
       
    }


    public static int GetEnemyCount()
    {
        return enemyCount;
    }
}