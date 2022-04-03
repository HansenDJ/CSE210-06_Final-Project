using System;
namespace generalNamespace;

public class Enemy : Character
{
    public int health = 5;
    // Linked to the player it's shot from
    public int enemyID = 0;

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
            if (levelOfEnemy == 100)
            {
                
                if (y < playery)
                {
                    y += chaseSpeed;
                }
                else if(y > playery)
                {
                    y -= chaseSpeed;
                }
            }
            else
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
    }

    public void SetLevelOneDifficulty()
    {
        levelOfEnemy = 1;
    }

    public void SetLevelTwoDifficulty()
    {
        levelOfEnemy = 2;
    }

    public void SetLevelThreeDifficulty()
    {
        levelOfEnemy = 3;
    }

    public void SetLevelBossDifficulty()
    {
        levelOfEnemy = 4;
    }
}