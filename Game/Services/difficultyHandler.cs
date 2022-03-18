namespace generalNamespace;

public static class DifficultyHandler
{
    public static float difficulty = 3F;
    public static int enemyCount = 3;
    
  

   public static void IncreaseDifficulty()
   {
       difficulty += 1;
       enemyCount += 1;
   }
   public enum Level 
   {
       VeryEasy,
       Easy,
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