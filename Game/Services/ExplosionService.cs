using Raylib_cs;
using Raylib_cs;
using static Raylib_cs.Raylib;
namespace generalNamespace;

public static class ExplosionService
{
   

    public static List<Texture2D> LoadAnimation()
    {
        List<Texture2D> explosionAnimation = new List<Texture2D>();
        
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp000()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp001()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp002()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp003()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp004()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp005()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp006()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp007()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp008()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp009()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp010()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp011()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp012()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp013()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp014()));
            explosionAnimation.Add(LoadTextureFromImage(ImageService.exp015()));

            return explosionAnimation;
    }
    
}