using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectsMovement : MonoBehaviour
{
    private void Update()
    {
        transform.position += Vector3.right * -10 * Time.deltaTime;
        transform.Rotate(20 * Time.deltaTime, 0, 15 * Time.deltaTime);
    }

}