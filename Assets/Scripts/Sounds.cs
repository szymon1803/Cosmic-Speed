using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    private void Start()
    {
            gameObject.GetComponent<AudioSource>().Play();
    }
}
