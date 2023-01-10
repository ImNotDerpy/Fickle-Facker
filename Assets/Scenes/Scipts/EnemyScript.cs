using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyScript : MonoBehaviour
{
    public NavMeshAgent Enemy;
    public Transform Player;
    public GameObject GameOver;
    public AudioSource CollectSound;

    void Update()
    {
        Enemy.SetDestination(Player.position);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.transform == Player)
        {
            CollectSound.Play();
            Destroy(Player.gameObject);
            GameOver.SetActive(true);
        }

    }
}
