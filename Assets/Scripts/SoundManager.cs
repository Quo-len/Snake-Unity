using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SoundManager {

    public enum Sound {
        SnakeMove,
        SnakeEat,
        SnakeDie
    }

   public static void PlaySound(Sound sound) {
        GameObject soundGameObject = new GameObject("Sound");
        AudioSource audioSource = soundGameObject.AddComponent<AudioSource>();
        audioSource.volume = 0.2f;
        audioSource.PlayOneShot(GetAudioClip(sound));    
    }

    private static AudioClip GetAudioClip(Sound sound) {
        foreach (GameResources.SoundAudioClip soundAudioClip in GameResources.instance.soundAudioClipArray){
            if (soundAudioClip.sound == sound) {
                return soundAudioClip.audioClip;
            }
        }
        Debug.LogError("Unknown sound " + sound.ToString());
        return null;
    }

}
