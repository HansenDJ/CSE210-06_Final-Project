using System;
namespace generalNamespace;
public class CollisionDetection
{
    Player player = new();
    
    public bool CheckCollision(Player player, Enemy enemy)
    {
        float distance = Convert.ToSingle(Math.Sqrt(Math.Pow(Convert.ToDouble((player.playerX - enemy.enemyX)), Convert.ToDouble(2)) + Math.Pow(Convert.ToDouble((player.playerY - enemy.enemyY)), Convert.ToDouble(2)))) - (player.playerRadius + enemy.enemyRadius);
        // Compares if the item is 0 distance away from another object, meaning it collided with an object
        if (distance <= 0) {
            // True means there was a collision
            return true;
        }
        else {
            // True means there wasn't a collison
            return false;
        }
    }
}