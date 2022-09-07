using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class AsteroidsGenerator : MonoBehaviour
{
    public GameObject Asteroid1;
    public GameObject Asteroid2;
    public GameObject Asteroid3;
    public GameObject Asteroid4;
    public float space = 20;
    public int IsRunning = 1;
    public int NumberOfSeconds;

    private void Start()
    {
        for (int i = 0; i < 15; i++)
        {
            CreateObjects();
        }
    }

    public void CreateObjects()
    {
        Instantiate(Asteroid1, new Vector3(Random.Range(50, space), Random.Range(-50, 50), 0), Quaternion.Euler(0, 0, 0));
        Instantiate(Asteroid2, new Vector3(Random.Range(50, space), Random.Range(-50, 50), 0), Quaternion.Euler(0, 0, 0));
        Instantiate(Asteroid3, new Vector3(Random.Range(50, space), Random.Range(-50, 50), 0), Quaternion.Euler(0, 0, 0));
        Instantiate(Asteroid4, new Vector3(Random.Range(50, space), Random.Range(-50, 50), 0), Quaternion.Euler(0, 0, 0));
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

