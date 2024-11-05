using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Main_Menu_State : MonoBehaviour
{
    public Game_Play_State GamePlayState;
    public TextMeshProUGUI scoreText;

    private void OnEnable()
    {
        
        mainMenuUi.setActive(true);
        scoreText.text = $"TOP SCORE: {Game_Instance.score}";


    }
   
   private void OnDisable()
   {
   mainMenuUi.setActive(false);
   }



}
