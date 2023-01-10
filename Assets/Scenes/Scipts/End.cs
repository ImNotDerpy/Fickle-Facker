using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    public GameObject Finish;
    public AudioSource CollectSound;
    public GameObject Player;
    private void OnCollisionEnter(Collision collision)
    {
        Finish.SetActive(true);
        Time.timeScale = 0f;
        CollectSound.Play();
        Destroy(Player);
    }
}
