using UnityEngine;
using System.Collections.Generic;
using System.Collections;
public class ChangeColorLogic : MonoBehaviour
{

    
        


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if(hit.collider != null) 
                {

                }
            }
        }

    }
}
