﻿using System;
using CSE210_06_Final_Project;
using generalNamespace;
using Raylib_cs;
internal class Program
{
    private static void Main(string[] args)
    {
        
        Raylib.InitWindow(VideoService.scrnWidth, VideoService.scrnHeight, "FLUX");
      
        while (!Raylib.WindowShouldClose()) // Detect window close button or ESC key
        {
              loadScreenVisual.loadScreen();
            if (Raylib.IsKeyDown(KeyboardKey.KEY_SPACE))
            {
                break;
            }

            
        }
          Director director = new Director();
        director.StartGame();
    //    GameLoop();
      
    }

    public void GameLoop(){
      


      //  GameLoop();

    }

}