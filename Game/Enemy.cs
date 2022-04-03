using System;
namespace generalNamespace;

public class Enemy : Character
{
    public int health = 5;
    public string enemyID = " ";

    // Timer for laser spawn delay
    public int laserCounter = 0;

    // Max laser spawn delay
    public int laserMaxCount = 600;

    public int levelOfEnemy;
    public int moveSpeed;
    public int chaseSpeed = 0;
    private readonly Random rnd = new();

    public void SetHealth()
    {
        health = 5 * DifficultyHandler.currentLevel +5* levelOfEnemy;
    }

    public void SetSpeedandHealth()
    {
        SetHealth();
        SetEnemyID();
        chaseSpeed = rnd.Next(1, 2) * levelOfEnemy;
        moveSpeed = rnd.Next(5, 8);
    }

    public void SetEnemyID()
    {
        int id1 = rnd.Next(1,9);
        int id2 = rnd.Next(1,9);
        int id3 = rnd.Next(1,9);
        int id4 = rnd.Next(1,9);

        char char1 = (char)(rnd.Next(97,122));
        char char2 = (char)(rnd.Next(97,122));
        char char3 = (char)(rnd.Next(97,122));
        char char4 = (char)(rnd.Next(97,122));

        enemyID = Convert.ToString(id1) + Convert.ToString(id2) + Convert.ToString(id3) + Convert.ToString(id4) + Convert.ToString(char1) + Convert.ToString(char2) + Convert.ToString(char3) + Convert.ToString(char4);
        Console.WriteLine("eNeMyId: " + enemyID);
    }
    public void MoveEnemy(int playery)
    {
        
        x -= moveSpeed;
      
            if (y < playery )
            {
                y += chaseSpeed;
            }
            else
            {
                y -= chaseSpeed;
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

    public void LevelBossDifficulty()
    {
        var levelBoss = new Enemy();
        levelBoss.levelOfEnemy = 4;
    }
}