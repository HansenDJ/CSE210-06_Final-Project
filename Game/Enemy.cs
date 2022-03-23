using System;
using Raylib_cs;

namespace generalNamespace;

public class Enemy : Character
{
    Random rnd = new Random();
    public int moveSpeed = 0;
    
    
    public void SetRandomMoveSpeed() {
        moveSpeed = rnd.Next(1, 3);
    }
    public void MoveEntity()
    {
        x -= moveSpeed;
    }
}
