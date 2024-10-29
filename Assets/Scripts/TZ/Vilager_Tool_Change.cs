using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vilager_Tool_Change : MonoBehaviour
{
    public GameObject[] tools;

    private void Start()
    {
        Change();
    }

    public void Change()
    {
        var index = Random.Range(0, tools.Length);
        for (int i = 0; i < tools.Length; ++i)
        {
            tools[i].SetActive(i == index);
        }
    }
}
