using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
   public Stone_Spawner StoneSpawner;
   private float m_timer;
   [SerializeField]
   private float m_delay = 2f;

   public void OnEnable()
   {
    
   }

}
