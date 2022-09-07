using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Asteroid"))
        {
            other.gameObject.GetComponent<Explosion>().Crash();
            gameObject.GetComponent<Explosion>().Crash();
            gameObject.GetComponent<Wave>().Boom();
        }
        if (other.CompareTag("Metal"))
        {
            other.gameObject.GetComponent<Explosion>().Crash();
            gameObject.GetComponent<Explosion>().Crash();
            gameObject.GetComponent<Wave>().Boom();
        }
        if (other.CompareTag("Bomb"))
        {
            other.gameObject.GetComponent<Explosion>().Crash();
            gameObject.GetComponent<Explosion>().Crash();
            other.gameObject.GetComponent<Wave>().Boom();
            gameObject.GetComponent<Wave>().Boom();
        }
    }
    private void OnDestroy()
    {
        try {
            GameObject.Find("Scorescript").GetComponent<Score>().GameOver();
            GameObject.Find("Scorescript").GetComponent<YourScore>().GameOver();
            GameObject.Find("Scorescript").GetComponent<UI>().OnMouseDown();

        } catch { }

    }
}
