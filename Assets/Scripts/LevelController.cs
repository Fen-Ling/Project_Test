using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelController : MonoBehaviour
{
   public Stone_Spawner Stone_Spawner;
   private float m_timer;

   [SerializeField]
   private float m_delay = 2f;

   public void OnEnable()
    {
        m_timer = Time.time - m_delay;
    }

    private void Update()
    {
        if (Time.time > m_timer + m_delay)
        {
            Stone_Spawner.Spawn();
            m_timer = Time.time;
        }

    }

}
