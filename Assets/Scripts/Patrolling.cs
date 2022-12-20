using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrolling : MonoBehaviour
{
    public float Speed = 5f;
    public float Distance = 10f;
    public Transform[] Points;

    private void Update()
    {
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
    }
}
