using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public AudioSource AudioSource;
    public static SoundManager Instance;
    public AudioSource SFXsource;

    // Start is called before the first frame update
    void Awake()
    {
        //singletone method

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
        SFXsource.clip = clip;
        SFXsource.PlayOneShot(clip);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
