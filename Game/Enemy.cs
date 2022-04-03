using System;
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
    public int chaseSpeed = 0;
    private readonly Random rnd = new();

    public void SetHealth()
    {
        health = 5 * DifficultyHandler.currentLevel +5* levelOfEnemy;
    }

    public void SetSpeedandHealth()
    {
        SetHealth();
        chaseSpeed = rnd.Next(0, 2) * levelOfEnemy;
        moveSpeed = rnd.Next(5, 8);
    }

    public void MoveEnemy(int playery,int playerx)
    {
        
        x -= moveSpeed;
        if (x >= playerx)
        {
            if (y < playery)
            {
                y += chaseSpeed;
            }
            else
            {
                y -= chaseSpeed;
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

    public void LevelBossDifficulty()
    {
        var levelBoss = new Enemy();
        levelBoss.levelOfEnemy = 4;
    }
}