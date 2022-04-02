namespace generalNamespace;

public class CollisionDetection
{
    private int actualX1; // Character1's collider box x coordinate
    private int actualX2; // Character2's collider box x coordinate
    private int actualY1; // Character1's collider box y coordinate
    private int actualY2; // Character2's collider box y coordinate
    private Player player = new();

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
        actualX1 = character1.x + character1.GetOffsetColliderWidth() / 2; // Character1's collider box x coordinate
        actualY1 = character1.y + character1.GetOffsetColliderHeight() / 2; // Character1's collider box y coordinate
        actualX2 = character2.x + character2.GetOffsetColliderWidth() / 2; // Character2's collider box x coordinate
        actualY2 = character2.y + character2.GetOffsetColliderHeight() / 2; // Character2's collider box y coordinate
        
        // Check if two images are touching
        if (actualX1 + character1.GetOffsetColliderWidth() / 2 < actualX2 + character2.GetColliderBoxWidth() &&
            actualX1 + character1.GetColliderBoxWidth() > actualX2 &&
            actualY1 < actualY2 + character2.GetColliderBoxHeight() &&
            character1.GetColliderBoxHeight() + actualY1 > actualY2)
            // Collision detected
            return true;
        return false;
    }
}