using Raylib_cs;
using CharacterNameSpace;

namespace CharacterNameSpace {
    /***************************************************************
    *   This class helps you:
    *       - check for collision
    *       - move or rotate actors given a list of actors
    *       - Check whether an actor is left, right, top, or
                bottom of another actor.
    ****************************************************************/
    class PhysicsService {
        
        //Doesn't need any field for now

        // Constructor
        public PhysicsService() {
            //Empty for now
        }

        /***************************************************************
        * Turns an actor into a Rectangle for the purpose of collision checking
        ****************************************************************/
        private Rectangle GetRectangle(Character character) {
            (float x, float y) topLeft = character.GetTopLeft();
            return new Rectangle(topLeft.x, topLeft.y, character.GetWidth(), character.GetHeight());
        }

        /***************************************************************
        *   Rotate all actors using the rotate method of each actor
        ****************************************************************/
        public void RotateActors(List<Character> characters) {
            foreach (Character character in characters) {
                character.Rotate();
            }
        }

        /***************************************************************
        *   Move all actors using the MoveWithVelocity() method of each actor
        ****************************************************************/
        public void MoveActors(List<Character> characters) {
            foreach (Character character in characters) {
                character.MoveWithVelocity();
            }
        }

        /***************************************************************
        *   Check for collision between 2 actors.
        ****************************************************************/
        public bool CheckCollision(Character character1, Character character2) {
            return Raylib.CheckCollisionRecs(this.GetRectangle(character1), this.GetRectangle(character2));
        }

        /***************************************************************
        *   Check for collision between an actor and a point (float 2-tuple)
        ****************************************************************/
        public bool CheckCollisionPoint(Character character, (float x, float y) point) {
            return Raylib.CheckCollisionPointRec(new System.Numerics.Vector2(point.x, point.y), this.GetRectangle(character));
        }

        /***************************************************************
        *   Check for collision between an actor (target) and a list of actors
        *   Return value:
        *       - The first actor in the list that collides with target
        *       - NULL if there is no collision between target and any of the
        *         actors in the actors list.
        ****************************************************************/
        public Character? CheckCollisionList(Character target, List<Character> characters) {
            foreach (Character character in characters) {
                if (Raylib.CheckCollisionRecs(this.GetRectangle(character), this.GetRectangle(target))) {
                    return character;
                }
            }
            return null;
        }

        /***************************************************************
        *   Check to see if an actor (target) collides with ALL of the
        *   actors in a list of actors.
        ****************************************************************/
        public bool CheckCollisionAll(Character target, List<Character> characters) {
            foreach (Character character in characters) {
                if (!Raylib.CheckCollisionRecs(this.GetRectangle(character), this.GetRectangle(target))) {
                    return false;
                }
            }
            return true;
        }

        /***************************************************************
        *   Is actor1 above actor2?
        ****************************************************************/
        public bool IsAbove(Character character1, Character character2) {
            return character1.GetTopLeft().Item2 < character2.GetTopLeft().Item2; 
        }

        /***************************************************************
        *   Is actor1 below actor2?
        ****************************************************************/
        public bool IsBelow(Character character1, Character character2)
        {
            return character1.GetBottomLeft().Item2 > character2.GetBottomLeft().Item2;
        }

        /***************************************************************
        *   Is actor1 left of actor2?
        ****************************************************************/
        public bool IsLeftOf(Character character1, Character character2) {
            return character1.GetTopLeft().Item1 < character2.GetTopLeft().Item1;
        }

        /***************************************************************
        *   Is actor1 right of actor2?
        ****************************************************************/
        public bool IsRightOf(Character character1, Character character2) {
            return character1.GetTopRight().Item1 > character2.GetTopRight().Item1;
        }

    }
}