using System;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace generalNamespace;

public class AudioService
{
    public Sound soundBattleLv1 = LoadSound("Game/sounds/battlelv1.wav");

    public AudioService()
    {
        InitAudioDevice();      // Initialize audio device
    }

    public Sound LoadAudio(Sound audioFile)
    {
        return audioFile;
    }

    public void PlayAudio(Sound audioFile)
    {
        LoadAudio(audioFile);
        PlaySound(audioFile);
    }

    public void UnloadAudio(Sound audioFile)
    {
        UnloadSound(audioFile);     // Unload sound data
    }

    public void CloseAudio()
    {
        CloseAudioDevice();     // Close audio device
    }
}