using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource AudioSource;
    public static SoundManager Instance;
    public AudioSource SFXsource;
    void Awake()
    {

        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
        
    }
    public void PlaySound(AudioClip clip)
    {
        SFXsource.PlayOneShot(clip);
    }
}
