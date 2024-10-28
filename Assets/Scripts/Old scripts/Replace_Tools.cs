using UnityEngine;

public class Replace_Tools : MonoBehaviour
{
    private int curNumTool = 0;
    public GameObject [] ObjTools;
    public GameObject curTools;
 
    //Для работы вкличи скрипты в руках у жителей: villeger/DummyRig/root/B-hips/B-spine/B-chest/B-upperChest/B-shoulder_R/B-upper_arm_R/B-forearm_R/B-hand_R
   void FixedUpdate()
   {
        if (Input.GetKey(KeyCode.Space))
        {
            curNumTool += 1;
            if (curNumTool == 4)
            {
                curNumTool = 0;
            }
            if (ObjTools[curNumTool] != null)
            {
                if (curTools != null)
                {
                    Destroy(curTools);
                }
                
                curTools = Instantiate(ObjTools[curNumTool], curTools.transform.position, curTools.transform.rotation, transform);
             
            }
        }

   }
  
}
