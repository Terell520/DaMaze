using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dacontrols : MonoBehaviour
{
    float thisISADecimal = 3.14f;
    // Start is called before the first frame update
    void Start()
    {
     Debug.Log(thisISADecimal);
     thisISADecimal++;
     
    }

    // Update is called once per frame
    void Update()
    {
     Vector3 newPos = transform.position;
        
            if (Input.GetKey(KeyCode.W))
            {
            newPos.z+= 0.5f;

        }
            if (Input.GetKey(KeyCode.S))
        { newPos.z -= 0.5f; }
            if (Input.GetKey(KeyCode.A))
        { newPos.x -= 0.5f; }
            if (Input.GetKey(KeyCode.D))
        { newPos.x += 0.5f; }
            
         //newPos.x+= 0.5f;
        
        //transform.position = new Vector3(3, 3, -10);

     //newPos.y++;

     transform.position = newPos;

    }
}
