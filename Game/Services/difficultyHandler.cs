namespace generalNamespace;

public static class DifficultyHandler
{
    public static int difficultyHandler = 0;
    public static int enemyCount = 3;
    public static int currentLevel = 1;
    public static int previousLevel = 1;
    public static bool levelChange = false;


    public static bool LevelUp(double time)
    {
        int lvl = Convert.ToInt32(time);
        currentLevel = 1 + lvl;
        if (currentLevel > previousLevel)
        {
            IncreaseDifficulty();
            // do level changes here;
            previousLevel = currentLevel;
            Console.WriteLine("Level UP " + currentLevel);
            levelChange = true;
            return true;
        }

        return false;
    }

    public static int GetEnemyLevel()
    {
        int difficulty = 1;
        Random rnd = new Random();
        difficulty = rnd.Next(1, 3);
        return difficulty;
    }
    
   
   public static void IncreaseDifficulty()
   {
       enemyCount += 5;
   }
  

   public static int GetEnemyCount()
   {
       return enemyCount;
   }

}