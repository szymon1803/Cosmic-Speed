using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuDestroingObjects : MonoBehaviour
{
    void Update()
    {
        if (transform.position.x < -750)
        {
            Destroy(gameObject);
        }
    }
}
