using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBomb : MonoBehaviour
{
    public GameObject Bomb;
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
        Instantiate(Bomb, new Vector3(Random.Range(900, 1100), Random.Range(-500, 500), Random.Range(500, 900)), Quaternion.Euler(0, 0, 0));
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
