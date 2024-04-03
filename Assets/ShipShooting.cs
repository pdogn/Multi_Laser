using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class ShipShooting : MonoBehaviour
{
    public int time;
    [SerializeField] GameObject bullet;
    [SerializeField] Transform bulletPos;
    [Space]
    [SerializeField] protected float shootDelay = 1f;
    [SerializeField] protected float shootTimer = 0f;
    [Space]
    [SerializeField] protected float isShooting;

    void Update()
    {
        IsShooting();
    }

    private void FixedUpdate()
    {
        Shooting();
    }

    void IsShooting()
    {
        isShooting = Input.GetAxis("Fire1");
    }
    void Shooting()
    {
        if (isShooting == 0) return;

        shootTimer += Time.fixedDeltaTime;
        if (shootTimer < shootDelay) return;
        shootTimer = 0f;

        GameObject _bullet = PhotonNetwork.Instantiate(bullet.name, bulletPos.position, bulletPos.rotation);
        _bullet.gameObject.GetComponent<PhotonView>().RPC("DestroyBullet", RpcTarget.All, time);
    }
}
