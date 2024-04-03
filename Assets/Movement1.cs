using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement1 : MonoBehaviour
{
    Rigidbody2D rb;

    Vector2 movement;
    Vector2 mousePos;

    public float speed = 3;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        InputAction();
    }

    private void FixedUpdate()
    {
        Movement_Rotation();
        
    }

    void InputAction()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    void Movement_Rotation()
    {
        rb.MovePosition(rb.position + movement * speed * Time.deltaTime);
        //rb.AddRelativeForce(Vector3.up * movement.y * speed);
        //rb.AddRelativeForce(Vector3.right * movement.x * speed, ForceMode2D.Force);

        Vector2 lookdir = mousePos - rb.position;
        float Angle = Mathf.Atan2(lookdir.y, lookdir.x) * Mathf.Rad2Deg - 90f;
        rb.rotation = Angle;
    }
}
