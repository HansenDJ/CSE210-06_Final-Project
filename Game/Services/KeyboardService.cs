using Raylib_cs;

namespace generalNamespace;

public static class KeyboardService
{
    public static bool WKeyDown()
    {
        return Raylib.IsKeyDown(KeyboardKey.KEY_W);
    }

    public static bool WKeyUp()
    {
        return Raylib.IsKeyUp(KeyboardKey.KEY_W);
    }

        public static bool SKeyDown()
    {
        return Raylib.IsKeyDown(KeyboardKey.KEY_S);
    }

    public static bool SKeyUp()
    {
        return Raylib.IsKeyUp(KeyboardKey.KEY_S);
    }
    public static bool AKeyDown()
    {
        return Raylib.IsKeyDown(KeyboardKey.KEY_A);
    }
    public static bool DKeyDown()
    {
        return Raylib.IsKeyDown(KeyboardKey.KEY_D);
    }
}