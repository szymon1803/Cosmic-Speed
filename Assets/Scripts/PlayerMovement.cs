using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed = 20f;
    public AudioSource Nitro;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            gameObject.transform.position += Vector3.down * speed * Time.deltaTime;
            if (gameObject.transform.localRotation.x < 30)
            {
                gameObject.transform.localRotation = Quaternion.Euler(30, 0, 0);
                //float tmp = 30 * Time.deltaTime;
                //if (tmp > 30) tmp = 30;
                //gameObject.transform.rotation = Quaternion.Euler(0, -180 + tmp, 90);
            }
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            gameObject.transform.position += Vector3.up * speed * Time.deltaTime;
            if (gameObject.transform.localRotation.x > -30)
            {
                gameObject.transform.localRotation = Quaternion.Euler(-30, 0, 0);
                //float tmp = 30 * Time.deltaTime;
                //if (tmp > 30) tmp = 30;
                //gameObject.transform.rotation = Quaternion.Euler(0, -180 + tmp, 90);
            }
        }
        else if ((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) == false)
        {
            gameObject.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            gameObject.transform.position += Vector3.right * 25 * Time.deltaTime;
        }
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (!Nitro.isPlaying)
            {
                Nitro.Play();
            }
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow))
        {
            Nitro.Stop();
        }
        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            gameObject.transform.position += Vector3.left * speed * Time.deltaTime;
        }
        if (gameObject.transform.position.y > 50)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, 50, gameObject.transform.position.z);
        }
        if (gameObject.transform.position.y < -50)
        {
            gameObject.transform.position = new Vector3(gameObject.transform.position.x, -50, gameObject.transform.position.z);
        }
        if (gameObject.transform.position.x > 30)
        {
            gameObject.transform.position = new Vector3(30, gameObject.transform.position.y, gameObject.transform.position.z);
        }
        if (gameObject.transform.position.x < -34)
        {
            gameObject.transform.position = new Vector3(-34, gameObject.transform.position.y, gameObject.transform.position.z);
        }
    }
}
