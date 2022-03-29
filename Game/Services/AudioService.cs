using System;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace generalNamespace;

public static class AudioService
{
    public static Sound lv1Shot = LoadSound("Game/sounds/lv1shot.wav");

    // Constructor
    public static void InitSound()
    {
        InitAudioDevice();      // Initialize audio device
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

    public static void UnloadAudio(Sound audioFile)
    {
        UnloadSound(audioFile);     // Unload sound data
    }

    public static void CloseAudio()
    {
        CloseAudioDevice();     // Close audio device
    }
}