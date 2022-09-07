using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject fracturedVersion;

    public void Crash()
    {
        Instantiate(fracturedVersion, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
