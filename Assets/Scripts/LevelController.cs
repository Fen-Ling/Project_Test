using System;
using System.Collections;
using System.Collections.Generic;
using Golf;
using UnityEngine;
namespace Golf
{
    public class LevelController : MonoBehaviour
    {
        public Stick stick;
        public Sound_Stoun S_sound;
        public Sound_Game_Over G_O_sound;
        public Stone_Spawner stoneSpawner;
        private float m_timer;
        [SerializeField]
        private float m_delay = 2f;
        private int m_score = 0;
        private List<Stone> m_stones = new List<Stone>();
        public event Action<int> onGameOver;
        public event Action<int> onScoreInc;

        public void OnEnable()
        {
            m_timer = Time.time - m_delay;
            stick.onCollisionStone += OnCollisionStick;

            m_score = 0;

            ClearStones();
        }
        private void OnDisable()
        {
            if (stick)
            {
                stick.onCollisionStone -= OnCollisionStick;
            }
        }
        private void ClearStones()
        {
            foreach (var stone in m_stones)
            {
                Destroy(stone.gameObject);
            }

            m_stones.Clear();
        }
        private void Update()
        {
            if (Time.time > m_timer + m_delay)
            {
                m_timer = Time.time;

                var go = stoneSpawner.Spawn();
                var stone = go.GetComponent<Stone>();

                stone.onCollisionStone += OnCollisionStone;

                m_stones.Add(stone);
            }
        }
        private void OnCollisionStick()
        {
            S_sound.PlayStoneSound();
            m_score++;
            Debug.Log($"score: {m_score}");
            onScoreInc?.Invoke(m_score);
        }
        private void OnCollisionStone()
        {
            G_O_sound.PlayGameOverSound();
            Debug.Log("GAME OVER!!!");
            onGameOver?.Invoke(m_score);
        }
    }
}