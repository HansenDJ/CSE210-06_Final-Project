namespace generalNamespace;

public class Enemy : Character
{
    public int health = 5;

    // Timer for laser spawn delay
    public int laserCounter = 0;

    // Max laser spawn delay
    public int laserMaxCount = 600;

    public int levelOfEnemy;
    public int moveSpeed;
    private readonly Random rnd = new();

    public void setHealth()
    {
        health = 5 * DifficultyHandler.currentLevel +5* levelOfEnemy;
    }

    public void SetSpeedandHealth()
    {
        setHealth();
        moveSpeed = rnd.Next(5, 8);
    }

    public void MoveEnemy(int playery)
    {
        x -= moveSpeed;
        if (levelOfEnemy == 3)
        {
            if (y < playery)
            {
                y += 3;
            }
            else
            {
                y -= 3;
            }
        }else if(levelOfEnemy == 2) {

                if (y < playery)
                {
                    y += 1;
                }
                else
                {
                    y -= 1;
                
            }
        }
    }

    public void LevelOneDifficulty()
    {
        var levelOne = new Enemy();
        levelOne.levelOfEnemy = 1;
    }

    public void LevelTwoDifficulty()
    {
        var levelTwo = new Enemy();
        levelTwo.levelOfEnemy = 2;
    }

    public void LevelThreeDifficulty()
    {
        var levelThree = new Enemy();
        levelThree.levelOfEnemy = 3;
    }
}