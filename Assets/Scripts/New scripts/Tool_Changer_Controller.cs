using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tool_Changer_Controller : MonoBehaviour
{
    public Vilager_Tool_Change[] vllagers;

    public void Change()
    {
        foreach (var vllager in vllagers)
        {
            vllager.Change();
        }
    }
}
