using System;
using Raylib_cs;

namespace generalNamespace;

public class Enemy : Character
{
    Random rnd = new Random();
    public int moveSpeed = 0;
    public int health = 5;
    // Timer for laser spawn delay
    public int laserCounter = 0;
    // Max laser spawn delay
    public int laserMaxCount = 600;

    public int levelOfEnemy = 0;

    public void setHealth(int hp)
    {
        health = hp;
    }
    public void SetRandomMoveSpeed() {
        moveSpeed = rnd.Next(5, 8);
    }
    public void MoveEnemy()
    {
        x -= moveSpeed;
    }

    public void LevelOneDifficulty ()
    {
       Enemy levelOne = new Enemy();
       levelOne.levelOfEnemy = 1;
    }

     public void LevelTwoDifficulty ()
    {
       Enemy levelTwo = new Enemy();
       levelTwo.levelOfEnemy = 2;
    }

    public void LevelThreeDifficulty ()
    {
       Enemy levelThree = new Enemy();
       levelThree.levelOfEnemy = 3;
    }
}