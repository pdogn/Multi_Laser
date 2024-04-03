using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSetup : MonoBehaviour
{
    [SerializeField] Movement1 movement;
    [SerializeField] ShipShooting shipShooting;


    public void IsLocalPlayer()
    {
        movement.enabled = true;
        shipShooting.enabled = true;
    }
}
