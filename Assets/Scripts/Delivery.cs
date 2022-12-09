using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    Color32 HasPackageColor = new Color32(0, 0, 0, 255);
    Color32 NoPackageColor = new Color32(255, 255, 255, 255);

    float DestroyDelay = .05f;
    bool HasPackage;
    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Ouch");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Package" && !HasPackage)
        {
            Debug.Log("Has Package");
            HasPackage = true;
            spriteRenderer.color = HasPackageColor;
            Destroy(collision.gameObject, DestroyDelay);
        }

        if (collision.tag == "Customer" && HasPackage)
        {
            Debug.Log("Delivered");
            HasPackage = false;
            spriteRenderer.color = NoPackageColor;

        }
    }
}
