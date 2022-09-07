using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public GameObject explosion;

    public void Boom()
    {
        Destroy(gameObject);
        Instantiate(explosion, transform.position, transform.rotation);
    }
}
