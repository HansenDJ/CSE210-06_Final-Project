namespace generalNamespace;

public static class DifficultyHandler
{
    public static int difficultyHandler = 0;
    public static int enemyCount = 3;
    public static int currentLevel = 1;
    public static int previousLevel = 1;
    public static bool levelChange;


    public static bool LevelUp(double time)
    {
        var lvl = Convert.ToInt32(Math.Floor(time));
        currentLevel = 1 + lvl;
        if (currentLevel > previousLevel)
        {
            IncreaseDifficulty();
            PlayerStats.maxPlayerHealth += 50;
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
        var difficulty = 1;
        var rnd = new Random();
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