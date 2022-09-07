using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundDestruction : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Asteroid"))
        {
            other.gameObject.GetComponent<Explosion>().Crash();
        }
        if (other.CompareTag("Metal"))
        {
            other.gameObject.GetComponent<Explosion>().Crash();
        }
        if (other.CompareTag("Ship"))
        {
            other.gameObject.GetComponent<Explosion>().Crash();
            other.gameObject.GetComponent<Wave>().Boom();
            GameObject.Find("Scorescript").GetComponent<Score>().GameOver();
            GameObject.Find("Scorescript").GetComponent<UI>().OnMouseDown();
        }
    }
}
