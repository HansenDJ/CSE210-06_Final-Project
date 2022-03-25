namespace generalNamespace;

public static class DifficultyHandler
{
    public static int difficultyHandler = 0;
    public static int enemyCount = 3;
    public static int level = 1;
    public static bool levelChange = false;


    public static void LevelUp()
    {
        level += 1;
        levelChange = true;
    }
    public static void incrementHandler()
    {
        difficultyHandler += 1;
        if (difficultyHandler == 4000)
        {
            difficultyHandler = 0;
            IncreaseDifficulty();
        }
    }
   public static void IncreaseDifficulty()
   {
       enemyCount += 1;
   }
   public enum Level 
   {
       
       Level1,
       Level2,
       Level3,
       Boss
   }

   public static int GetEnemyCount()
   {
       return enemyCount;
   }

}