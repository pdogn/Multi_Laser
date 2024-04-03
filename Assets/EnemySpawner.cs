using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject enemy;
    [SerializeField] float timeDelay = 1f;
    [SerializeField] float timer;

    private void Start()
    {
        timer = timeDelay;
    }

    void Update()
    {
        Spawning();
    }

    void Spawning()
    {
        if(PhotonNetwork.IsMasterClient == false || PhotonNetwork.CurrentRoom.PlayerCount != 2)
        {
            return;
        }

        if (timer < 0)
        {
            Vector3 spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)].position;
            PhotonNetwork.Instantiate(enemy.name, spawnPoint, Quaternion.identity);
            timer = timeDelay;
        }
        else
        {
            timer -= Time.deltaTime;
        }
    }
}
