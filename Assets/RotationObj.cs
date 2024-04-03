using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationObj : MonoBehaviour
{
    Rigidbody2D rb;
    public GameObject player;
    public bool isPlayer;

    Vector2 mousePos;
    Vector2 playerPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        InPutAction();
    }
    private void Update()
    {
        InPutAction();
    }

    private void FixedUpdate()
    {
        RotateObj();
    }

    void InPutAction()
    {
        if (!isPlayer)
        {
            if (player = GameObject.FindGameObjectWithTag("Player"))
            {
                //player = GameObject.FindGameObjectWithTag("Player");
                playerPos = player.transform.position;
            }
        }
        else
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }
    }

    void RotateObj()
    {
        if(isPlayer)
        {
            Vector2 lookdir = mousePos - rb.position;
            float Angle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 90f;
            rb.rotation = Angle;
        }
        else
        {
            Vector2 lookdir = playerPos - rb.position;
            float Angle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 90f;
            rb.rotation = Angle;
        }
    }
}
