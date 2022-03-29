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

    public void setHealth(int hp)
    {
        health = hp;
    }
    public void SetRandomMoveSpeed() {
        moveSpeed = rnd.Next(5, 8);
    }
    public void MoveEntity()
    {
        x -= moveSpeed;
    }
}
