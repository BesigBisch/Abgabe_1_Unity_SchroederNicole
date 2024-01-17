using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public AudioSource CorrectSound;
    public AudioSource WrongSound;
    //public AudioSource WinSound;

    public void PlayCorrectSound()
    {
        CorrectSound.Play();
    }

    public void PlayWrongSound()
    {
        WrongSound.Play();
    }

    //wenn alle 3 Wörter gefunden wurden, spielt es folgenden Sound ab
    //public void PlayWinSound()
    //{
    //    WinSound.Play();
    //}


}
