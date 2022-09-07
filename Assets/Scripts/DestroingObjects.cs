using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroingObjects : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x < -40)
        {
            Destroy(gameObject);
        }
    }
}
