using System;
using UnityEngine;

public class DestroingBullets : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
            other.gameObject.GetComponent<Explosion>().Crash();
        }
        if (other.CompareTag("Metal"))
        {
            Destroy(gameObject);
        }
        if (other.CompareTag("Bomb"))
        {
            other.gameObject.GetComponent<Explosion>().Crash();
            other.gameObject.GetComponent<Wave>().Boom();
            Destroy(gameObject);
        }
    }
}
