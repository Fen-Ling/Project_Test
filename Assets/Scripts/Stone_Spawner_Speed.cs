using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone_Spawner_Speed : MonoBehaviour
{
   [SerializeField]
    private Transform m_point;
    [SerializeField]
    private GameObject[] m_Prefabs;

    private float initialFallSpeed = 1f; // Начальная скорость падения
    private float maxFallSpeed = 50f; // Максимальная скорость падения
    private float spawnInterval = 0.5f; // Интервал спавна в секундах
    private float fallSpeedIncrease = 0.1f; // Увеличение скорости падения после каждого спавна
    private float m_currentDelay;

    private void Start()
    {
        if (m_point == null)
        {
            m_point = transform;
        }

        m_currentDelay = spawnInterval;
        StartCoroutine(SpawnStones());
    }

    private IEnumerator SpawnStones()
    {
        while (true)
        {
            Spawn();
            yield return new WaitForSeconds(m_currentDelay);
        }
    }

    public GameObject Spawn()
    {
        if (m_Prefabs.Length == 0)
        {
            Debug.LogWarning("No prefabs assigned to spawn.");
            return null;
        }

        int index = Random.Range(0, m_Prefabs.Length);
        GameObject stone = Instantiate(m_Prefabs[index], m_point.position, m_point.rotation);

        Rigidbody rb = stone.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = new Vector3(0, -initialFallSpeed, 0);
        }

        return stone;
    }

    public void IncreaseFallSpeed()
    {
        initialFallSpeed = Mathf.Min(initialFallSpeed + fallSpeedIncrease, maxFallSpeed);
        m_currentDelay = Mathf.Max(0.5f, m_currentDelay - 0.1f); // Например, уменьшаем время спавна
    }
}
