using System;

namespace generalNamespace;

public class CollisionDetection
{
    Player player = new();

    // Distance formula between two circles to detect collision: sqrt((x2 − x1)^2 + (y2 − y1)^2) − (r2 + r1)
    // public bool CheckCollision(Player player, Enemy enemy)
    // {
    //     float distance = Convert.ToSingle(Math.Sqrt(Math.Pow(Convert.ToDouble((player.x - enemy.x)), Convert.ToDouble(2)) + Math.Pow(Convert.ToDouble((player.y - enemy.y)), Convert.ToDouble(2)))) - (player.radius + enemy.radius);
    //     // Compares if the item is 0 distance away from another object, meaning it collided with an object
    //     if (distance <= 0) {
    //         // True means there was a collision
    //         return true;
    //     }
    //     else {
    //         // True means there wasn't a collison
    //         return false;
    //     }
    // }

    // Detect collision between two characters. Their collision box is calculated by the height and width of their image file.   
    public bool CheckCollision(Character character1, Character character2)
    {
        // Check if two images are touching
        if (character1.x < character2.x + character2.GetImageWidth() - character2.offsetWidth &&
        character1.x + character1.GetImageWidth() - character1.offsetWidth > character2.x &&
        character1.y < character2.y + character2.GetImageHeight() - character2.offsetHeight &&
        character1.GetImageHeight() - character1.offsetHeight + character1.y > character2.y)
        {
            // Collision detected
            return true;
        }
        else
        {
            // No collision
            return false;
        }
    }
}