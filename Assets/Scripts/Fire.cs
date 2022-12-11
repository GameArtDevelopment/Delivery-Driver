using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public Transform FirePt;
    public GameObject Projectile;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(Projectile, FirePt.position, FirePt.rotation);
        }
    }
}
