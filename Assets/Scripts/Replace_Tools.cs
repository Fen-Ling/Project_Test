using UnityEngine;

public class Replace_Tools : MonoBehaviour
{
    private int curNumTool = 0;
    public GameObject [] ObjTools;
    public GameObject curTools;
 
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
