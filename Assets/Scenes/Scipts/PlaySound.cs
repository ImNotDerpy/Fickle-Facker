using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource SoundPlayer;

    public void playThisSoundEffect()
    {
        SoundPlayer.Play();
    }
}
