using System.Security.Cryptography.X509Certificates;
using UnityEngine;

namespace Golf
{
    public class PlayerController : MonoBehaviour
    {
        public Transform stick;
        public float maxAngle = 30f;
        public float speed = 360f;
       

        private void Awake()
        {
            Application.targetFrameRate = 30;
        }

        private void FixedUpdate()
        {
            Vector3 angle = stick.localEulerAngles;
            if (Input.GetMouseButton(0))
            {
                Stick.Down();
            }
            else
            {
                Stick.Up();        
            }

            stick.localEulerAngles = angle;


        }

        private void OnCollisionEnter (Collision collision)
        {

        }

    }
}


