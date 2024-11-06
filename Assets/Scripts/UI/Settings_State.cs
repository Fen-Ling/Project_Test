using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings_State : MonoBehaviour
{
    public GameObject SetteingsUI;
    public Main_Menu_State mainMenuState;
    private void OnEnable()
    {
        SetteingsUI.SetActive(true);
    }
    private void OnDisable()
    {
        if (SetteingsUI)
        {
            SetteingsUI.SetActive(false);
        }
    }
    public void BackToMainMenu()
    {
        gameObject.SetActive(false);
        mainMenuState.gameObject.SetActive(true);
    }
}
