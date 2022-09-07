using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject GameOverPanel;
    public void OnMouseDown()
    {
        GameOverPanel.SetActive(true);
    }
}
