using Raylib_cs;

namespace generalNamespace;

public static class KeyboardService
{
    public static bool WKeyDown()
    {
        return Raylib.IsKeyDown(KeyboardKey.KEY_W);
    }

    public static bool WKeyReleased()
    {
        return Raylib.IsKeyReleased(KeyboardKey.KEY_W);
    }

    public static bool SKeyDown()
    {
        return Raylib.IsKeyDown(KeyboardKey.KEY_S);
    }

    public static bool SKeyReleased()
    {
        return Raylib.IsKeyReleased(KeyboardKey.KEY_S);
    }

    public static bool AKeyDown()
    {
        return Raylib.IsKeyDown(KeyboardKey.KEY_A);
    }

    public static bool DKeyDown()
    {
        return Raylib.IsKeyDown(KeyboardKey.KEY_D);
    }

    public static bool AKeyReleased()
    {
        return Raylib.IsKeyReleased(KeyboardKey.KEY_A);
    }

    public static bool DKeyReleased()
    {
        return Raylib.IsKeyReleased(KeyboardKey.KEY_D);
    }

    public static bool UpKeyDown()
    {
        return Raylib.IsKeyDown(KeyboardKey.KEY_UP);
    }

    public static bool DownKeyDown()
    {
        return Raylib.IsKeyDown(KeyboardKey.KEY_DOWN);
    }

    public static bool LeftKeyDown()
    {
        return Raylib.IsKeyDown(KeyboardKey.KEY_LEFT);
    }

    public static bool RightKeyDown()
    {
        return Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT);
    }


    public static bool SpaceKeyDown()
    {
        return Raylib.IsKeyDown(KeyboardKey.KEY_SPACE) || Raylib.IsKeyDown(KeyboardKey.KEY_ENTER);
    }

    public static bool UpKeyReleased()
    {
        return Raylib.IsKeyReleased(KeyboardKey.KEY_UP);
    }

    public static bool DownKeyReleased()
    {
        return Raylib.IsKeyReleased(KeyboardKey.KEY_DOWN);
    }

    public static bool LeftKeyReleased()
    {
        return Raylib.IsKeyReleased(KeyboardKey.KEY_LEFT);
    }

    public static bool RightKeyReleased()
    {
        return Raylib.IsKeyReleased(KeyboardKey.KEY_RIGHT);
    }
}