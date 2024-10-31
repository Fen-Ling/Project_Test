using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace TZ
{
    public class PlayerController : MonoBehaviour
    {
        [SerializeField]
        private FreeCamera freeCamera;
        public GameObject ui;
        public Stone_Spawner stoneSpawner;
        public Controller_Cloud cloudController;
        public Tool_Changer_Controller toolChangerController;

        private void Update()
        {
            if (ui.activeSelf)
            {
                return;
            }

            if (freeCamera != null)
            {
                freeCamera.Move();
            }

            if (stoneSpawner != null)
            {
                if (Input.GetKeyDown(KeyCode.X))
                {
                    stoneSpawner.Spawn();
                }
            }

            if (cloudController != null)
            {
                if (Input.GetKeyDown(KeyCode.Z))
                {
                    cloudController.MoveNext();
                }
            }

            if (toolChangerController != null)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    toolChangerController.Change();
                }
            }
        }
    }
}