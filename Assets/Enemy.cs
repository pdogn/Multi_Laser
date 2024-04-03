using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public PlayerSetup[] players;
    public PlayerSetup nearestPlayer;

    public float enemySpeed;

    private void Start()
    {
        players = FindObjectsOfType<PlayerSetup>();
    }

    private void Update()
    {
        EnemyMove();
    }

    void EnemyMove()
    {
        float distanceOne = Vector2.Distance(transform.position, players[0].transform.position);
        float distanceTwo = Vector2.Distance(transform.position, players[1].transform.position);

        if(distanceOne < distanceTwo)
        {
            nearestPlayer = players[0];
        }
        else
        {
            nearestPlayer = players[1];
        }

        if(nearestPlayer != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, nearestPlayer.transform.position, enemySpeed*Time.deltaTime);
        }
    }
}
