using CSE210_06_Final_Project;
using generalNamespace;
using Raylib_cs;

internal class Program
{
    private static void Main(string[] args)
    {
        bool loadinstructions = false; 
        Raylib.InitWindow(VideoService.scrnWidth, VideoService.scrnHeight, "FLUX");


        while (!Raylib.WindowShouldClose()) // Detect window close button or ESC key
        {

           
            if (loadinstructions)
           {
               instructions.loadScreen();
           } 
           else
           {
                loadScreenVisual.loadScreen(); 
           }


         
            if(Raylib.IsKeyDown(KeyboardKey.KEY_I)){
                loadinstructions = true;
            }
            if(Raylib.IsKeyDown(KeyboardKey.KEY_BACKSPACE)){
                loadinstructions = false;
            }

            if(Raylib.IsKeyDown(KeyboardKey.KEY_R)) break;
        }

        var director = new Director();
        director.StartGame();
        //    GameLoop();
    }

    public void GameLoop()
    {
        //  GameLoop();
    }
}