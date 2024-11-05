using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Golf;
using UnityEngine;

public class Game_Play_State : MonoBehaviour
{
    public PlayerController playerController;
    public LevelController levelController;
    public GameObject rootUI;
    private void OnEnable()
    {
        rootUI.SetActive(true);
        playerController.enabled = true;
        levelController.enabled = true;
        levelController.

    }
    private void OnDisable()
    {
        
    }
    private void OnScoreInc()
    {

    }
    private void OnGameover()
    {

    }

}
