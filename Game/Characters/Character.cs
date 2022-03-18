namespace generalNamespace;
public class Character {

    private string path;
    private int width;
    private int height;
    
    private float x;
    private float y;
    private float velocityX;
    private float velocityY;

    private float rotation;
    private float rotationVelocity;

    private bool flipped;

    // Constructor//
    public Character(string path, int width, int height,
            float x = 0, float y = 0,
            float vx = 0, float vy = 0,
            float rotation = 0, float rotationVel = 0,
            bool flipped = false) {
        this.path = path;

        this.width = width;
        this.height = height;

        this.x = x;
        this.y = y;

        this.velocityX = vx;
        this.velocityY = vy;

        this.rotation = rotation;
        this.rotationVelocity = rotationVel;

        this.flipped = flipped;
    }
    
    
    // RETURN path of character
    public string GetPath() {
        return this.path;
    }

    // SET path of character
    public void SetPath(string path) {
        this.path = path;
    }

    
    // RETURN width of character
    public int GetWidth() {
        return this.width;
    }

    // SET width of character
    public void SetWidth(int width) {
        this.width = width;
    }

    // RETURN height of character
    public int GetHeight() {
        return this.height;
    }

    // SET height of character
    public void SetHeight(int height) {
        this.height = height;
    }

    // RETURN character position
    public (float x, float y) GetPosition() {
        return (this.x, this.y);
    }

    // RETURN character x
    public float GetX() {
        return this.x;
    }

    // SET character x
    public void SetX(float x) {
        this.x = x;
    }

    // RETURN character y
    public float GetY() {
        return this.y;
    }

    // SET character y
    public void SetY(float y) {
        this.y = y;
    }

/* Was GetVx() */
    // RETURN character velocity in x direction
    public float GetVelocityX() {
        return this.velocityX;
    }

/* Was SetVx() */
    // SET character velocity in x direction
    public void SetVelocityX(float velocityX) {
        this.velocityX = velocityX;
    }

/* Was GetVy() */
    // RETURN charater velocity in y direction
    public float GetVelocityY() {
        return this.velocityY;
    }

/* Was SetVy() */
    // SET character velocity in y direction
    public void SetVelocityY(float velocityY) {
        this.velocityY = velocityY;
    }

    // Getters for top-left corner of the rectangle//
    public (float, float) GetTopLeft() {
        return (this.x - this.width/2, this.y - this.height/2);
    }
    
    public (float, float) GetTopRight()
    {
        return (this.x + this.width / 2, this.y - this.height / 2);
    }

    public (float, float) GetBottomLeft()
    {
        return (this.x - this.width / 2, this.y + this.height / 2);
    }

    public (float, float) GetBottomRight()
    {
        return (this.x + this.width / 2, this.y + this.height / 2);
    }

    // Set/Get methods for rotation and rotation_vel//
    public float GetRotation() {
        return this.rotation;
    }

    public void SetRotation(float rotation) {
        this.rotation = rotation;
    }

    public float GetRotationVelocity() {
        return this.rotationVelocity;
    }

    public void SetRotationVel(float rotationVelocity) {
        this.rotationVelocity = rotationVelocity;
    }

/*
    // Set/Get methods for flipped
    public bool GetFlipped() {
        return this.flipped;
    }
*/

    public void SetFlipped(bool flipped) {
        this.flipped = flipped;
    }

    // Move character with velocity
    public void MoveWithVelocity() {
        this.x += this.velocityX;
        this.y += this.velocityY;
    }

    // Rotate current character
    public void Rotate() {
        this.rotation += this.rotationVelocity;
    }
}