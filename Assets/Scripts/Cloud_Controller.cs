using UnityEngine;

public class Cloud_Controller : MonoBehaviour
{
    public GameObject objectToMove;
    public Transform[] waypoints;
    private bool isMoving = false;
    private int currentWaypoint = -1;
    private float speed = 10f;


    void Start()
    {
        StopRain();
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            isMoving = true;
            StopRain();

            if (currentWaypoint < waypoints.Length-1)
            {
                currentWaypoint++;
            }
            else
            {
                currentWaypoint = 0;
            }
        }

        if (isMoving)
        {
            Moving();
        }
    }

    void Moving()
    {
        Vector3 nextWaypiont = new Vector3(waypoints[currentWaypoint].position.x, objectToMove.transform.position.y, waypoints[currentWaypoint].position.z);
        objectToMove.transform.position = Vector3.MoveTowards(objectToMove.transform.position, nextWaypiont, speed * Time.deltaTime);

        Vector3 cloud = new Vector3(objectToMove.transform.position.x, 0, objectToMove.transform.position.z);
        Vector3 villager = new Vector3(waypoints[currentWaypoint].position.x, 0, waypoints[currentWaypoint].position.z);

        if (Vector3.Distance(cloud, villager) < 0.1f)
        {
            isMoving = false;
            PlayRain();
        }

    }

    void PlayRain()
    {
        objectToMove.GetComponent<ParticleSystem>().Play();
    }

    void StopRain()
    {
        objectToMove.GetComponent<ParticleSystem>().Stop();
    }
}
