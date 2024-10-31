using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace Golf
{
    public class PlayerController : MonoBehaviour
    {
        public Transform stick;
        public float maxAngle = 30f;
        public float speed = 1f;
        public float returnspeed = 0.5f;

        private void Update()
        {
            Vector3 angle = stick.localEulerAngles;
            if (Input.GetMouseButton(0))
            {
                angle.z = Mathf.Min(angle.z + speed * Time.deltaTime, maxAngle);
            }
            else
            {
                angle.z = Mathf.Max(angle.z - returnspeed * Time.deltaTime, 360 - maxAngle);
            }

            stick.localEulerAngles = angle;


        }

    }
}


