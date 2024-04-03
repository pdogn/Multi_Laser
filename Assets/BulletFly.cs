using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BulletFly : MonoBehaviour
{
    [SerializeField] protected int moveSpeed = 1;
    [SerializeField] protected Vector2 direction = Vector2.up;

    void Update()
    {
        transform.Translate(moveSpeed * Time.deltaTime * direction);
    }

    [PunRPC]
    public void DestroyBullet( int timeToDestroy)
    {
        Destroy(gameObject, timeToDestroy);
    }
}
