using UnityEngine;

public class Spawn_Stone: MonoBehaviour
{
    public GameObject Object;
    public Transform Position;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            SpawnObjects();
        }
    }

    void SpawnObjects()
    {
        Instantiate(Object, Position.position, Quaternion.identity);
    }
}
