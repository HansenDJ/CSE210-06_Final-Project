using Raylib_cs;
using static Raylib_cs.Raylib;

namespace generalNamespace;

public static class AudioService
{
    public static Sound lv1Shot = LoadSound("Game/sounds/lv1shot.wav");
    public static Sound lv2Shot = LoadSound("Game/sounds/lv2shot.wav");
    
    public static Sound playershot1 = LoadSound("Game/sounds/laser8.mp3");
    public static Sound playershot2 = LoadSound("Game/sounds/laser7.mp3");
    public static Sound playershot3 = LoadSound("Game/sounds/laser6.mp3");
    public static Sound playershot4 = LoadSound("Game/sounds/laser5.mp3");
    public static Sound playershot5 = LoadSound("Game/sounds/laser4.mp3");
    public static Sound playershot6 = LoadSound("Game/sounds/laser3.mp3");
    public static Sound playershot7 = LoadSound("Game/sounds/laser2.mp3");
    public static Sound playershot8 = LoadSound("Game/sounds/laser1.mp3");
    public static Sound playershot9 = LoadSound("Game/sounds/powerUp4.mp3");


    public static Sound bossShot1 = LoadSound("Game/sounds/laser1.mp3");
    public static Sound bossShot2 = LoadSound("Game/sounds/laser1.mp3");
    public static Sound bossSpawn = LoadSound("Game/sounds/powerUp3.mp3");
    
    public static Sound battlelv1 = LoadSound("Game/sounds/battlelv1.wav");
    public static Sound battlelv2 = LoadSound("Game/sounds/battlelv2.wav");
    public static Sound battlelv3 = LoadSound("Game/sounds/battlelv3.wav");
    public static Sound battlelv4 = LoadSound("Game/sounds/battlelv4.wav");
    public static Sound battlelv5 = LoadSound("Game/sounds/battlelv5.wav");
   
    public static Sound GameOverSound = LoadSound("Game/sounds/game_over.wav");
    public static Sound audioPast = LoadSound("Game/sounds/battlelv1.wav");
    public static Sound audioCurrent = LoadSound("Game/sounds/battlelv1.wav");
    
    public static Sound explosion1 = LoadSound("Game/sounds/explosion01.wav");
    public static Sound explosion2 = LoadSound("Game/sounds/explosion02.wav");
    public static Sound explosion3 = LoadSound("Game/sounds/explosion03.wav");
    public static Sound explosion4 = LoadSound("Game/sounds/explosion04.wav");
    public static Sound explosion5 = LoadSound("Game/sounds/explosion05.wav");
    public static Sound explosion6 = LoadSound("Game/sounds/explosion06.wav");
    public static Sound explosion7 = LoadSound("Game/sounds/explosion07.wav");
    public static Sound explosion8 = LoadSound("Game/sounds/explosion08.wav");
    public static Sound explosion9 = LoadSound("Game/sounds/explosion09.wav");
    
    public static Sound bounceShot = LoadSound("Game/sounds/phaserUp6.mp3");
    
    public static Sound hurtPlayer = LoadSound("Game/sounds/phaserDown1.mp3");
    public static Sound healPlayer = LoadSound("Game/sounds/phaserUp2.mp3");
    public static Sound shieldPlayer = LoadSound("Game/sounds/phaserUp6.mp3");
    public static Sound bouncePlayer = LoadSound("Game/sounds/phaserUp7.mp3");
    
    
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