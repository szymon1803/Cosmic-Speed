using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetalGenerator : MonoBehaviour
{
    public GameObject Wing;
    public GameObject Satelliteblend;
    public GameObject Spacedoor;
    public float space = 20;
    public int IsRunning = 1;
    public int NumberOfSeconds;

    private void Start()
    {
        for (int i = 0; i < 1; i++)
        {
            CreateObjects();
        }
    }

    public void CreateObjects()
    {
        Instantiate(Wing, new Vector3(Random.Range(40, 50), Random.Range(-50, 50), 0), Quaternion.Euler(0, 0, 0));
        Instantiate(Satelliteblend, new Vector3(Random.Range(50, 60), Random.Range(-50, 50), 0), Quaternion.Euler(0, 0, 0));
        Instantiate(Spacedoor, new Vector3(Random.Range(60, 70), Random.Range(-50, 50), 0), Quaternion.Euler(0, 0, 0));
        space += 20;
    }

    public void Update()
    {
        if (IsRunning == 1)
        {
            StartCoroutine(Wait());
        }
    }

    public IEnumerator Wait()
    {
        IsRunning = 0;
        yield return new WaitForSeconds(NumberOfSeconds);
        Start();
        IsRunning = 1;
    }
}
