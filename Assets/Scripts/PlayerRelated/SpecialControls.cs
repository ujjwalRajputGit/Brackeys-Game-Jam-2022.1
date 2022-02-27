using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialControls : MonoBehaviour
{ 
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))
        {
            EventManager.instance.SolidGlitch();
        }else if (Input.GetKeyUp(KeyCode.J))
        {
            EventManager.instance.TransparentGlitch();
        }
        
    }
}
