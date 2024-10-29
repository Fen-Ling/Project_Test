using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MBlogger : MonoBehaviour
{
    private void Awake()
    {
        Log("Avake");
    }

    private void OnEnable()
    {
        Log("OnEnable");
    }

    private void Start()
    {
        Log("Start");
    }

    public void FixedUpdate()
    {

    }
    
    public void Update()
    {

    }

    public void LateUpdate()
    {

    }

    public void OnDisable()
    {
        Log("OnDisable");
    }

    public void OnDestroy()
    {
        Log("OnDestroy");
    }
   private void Log(string msg)
   {
        Debug.Log($"{name} {msg} - frame{Time.frameCount}");
   }
}
