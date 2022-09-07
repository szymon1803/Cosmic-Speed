using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject foam;
    public float launchVelocity = 2500f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instFoam = Instantiate(foam, transform.position, Quaternion.identity);
            Rigidbody instFoamRB = instFoam.GetComponent<Rigidbody>();
            instFoamRB.AddForce(gameObject.transform.right * launchVelocity);
            Destroy(instFoam, 2f);
        }
    }
}
