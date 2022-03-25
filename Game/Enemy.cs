using System;
using Raylib_cs;

namespace generalNamespace;

public class Enemy : Character
{
    Random rnd = new Random();
    public int moveSpeed = 0;
    public int health = 5;

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
