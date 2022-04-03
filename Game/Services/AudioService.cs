using Raylib_cs;
using static Raylib_cs.Raylib;

namespace generalNamespace;

public static class AudioService
{
    public static Sound lv1Shot = LoadSound("Game/sounds/lv1shot.wav");
    public static Sound lv2Shot = LoadSound("Game/sounds/lv2shot.wav");
    
    public static Sound battlelv1 = LoadSound("Game/sounds/battlelv1.wav");
    public static Sound battlelv2 = LoadSound("Game/sounds/battlelv2.wav");
    public static Sound battlelv3 = LoadSound("Game/sounds/battlelv3.wav");
    public static Sound battlelv4 = LoadSound("Game/sounds/battlelv4.wav");
    public static Sound battlelv5 = LoadSound("Game/sounds/battlelv5.wav");
   
    public static Sound GameOverSound = LoadSound("Game/sounds/game_over.wav");
    public static Sound audioPast = LoadSound("Game/sounds/battlelv1.wav");
    public static Sound audioCurrent = LoadSound("Game/sounds/battlelv1.wav");
    
    
    // Constructor
    public static void InitSound()
    {
        InitAudioDevice(); // Initialize audio device
    }

    public static Sound LoadAudio(Sound audioFile)
    {
        return audioFile;
    }

    public static void PlayAudio(Sound audioFile)
    {
       
        LoadAudio(audioFile);
        PlaySound(audioFile);
        
    }
    
    public static void PlayAudioBackground(Sound audioFile)
    {
            
           // UnloadAudio(audioCurrent);
      //      audioCurrent = audioFile;
        //    LoadAudio(audioFile);
       //    PlaySound(audioCurrent);
            
        
       
       
      
        
    }

    public static void EndSound()
    {
       // StopSoundMulti();
    }

    public static void UnloadAudio(Sound audioFile)
    {
        UnloadSound(audioFile); // Unload sound data
    }

    public static void CloseAudio()
    {
        CloseAudioDevice(); // Close audio device
    }

    // public static void DiedSound(){
    //     if(PlayerStats.playerHealth == 0){
    //         AudioService.LoadAudio(AudioService.GameOverSound);
    //         AudioService.PlayAudio(AudioService.GameOverSound);
    //     }
    // }
}