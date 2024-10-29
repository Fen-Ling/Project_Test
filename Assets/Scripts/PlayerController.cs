using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace Golf
{
    public class PlayerController : MonoBehaviour
    {
        public Transform stick;
        public float maxAngle = 30f;

        public float speed = 1f;

        private void Update()
        {
            var angle = stick.localEulerAngles;
            if (Input.GetMouseButton (0))
            {
                angle.z += speed * Time.deltaTime;
                angle.z = Mathf.Min (angle.z, maxAngle);
            }
            else 
            {
                angle.z -= speed * Time.deltaTime;
                angle.z = Mathf.Max (angle.z, -maxAngle);
            }

            stick.localEulerAngles = angle;
        }
    }
}