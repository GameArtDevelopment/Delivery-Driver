using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    public float SteerSpeed = 250f, MoveSpeed = 20f, SlowSpeed = 15f, BoostSpeed = 30f;

    private void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * SteerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * MoveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        MoveSpeed = SlowSpeed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Boost")
        {
            MoveSpeed = BoostSpeed;
        }
    }
}
