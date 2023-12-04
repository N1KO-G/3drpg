using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    
       static AudioSource AudioSource;
    public void Play(AudioClip audioClip)
    {
        AudioSource.PlayOneShot(audioClip);
    }
    void Awake()
    {
        if (!AudioSource)
        {
            var go = new GameObject("UI Audio");
            AudioSource = go.AddComponent<AudioSource>();
            DontDestroyOnLoad(go);
        }
    }
}

