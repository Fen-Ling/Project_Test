using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Golf
{


    public class Stick : MonoBehaviour
    {
        private bool m_isDown = false;

        public void Down() 
        {
            m_isDown = false;
        }
        public void Up()
        {
            m_isDown = true;
        }

        
        private void OnCollisionEnter(Collision other)
        {
            Debug.Log (other, this);
            if (other.rigidbody)
            {
               var contact = other.contacts[0];
               
            }
        }
    }
}
