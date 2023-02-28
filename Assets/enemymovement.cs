using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        target = { newPos.y - = 9.46}
        target = end;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = MoveEnemy();
    }
    Vector3 MoveEnemy()
    {
        float distance = Vector3.Distance(transform.position, target);
        float step = speed * Time.deltaTime;
        if (distance < 0.1f){
            if(target == end.position){
                target = start.position;
            }else if(target == start.position){
                target = end.position;
            }
        }
        return Vector3.MoveTowards(transform.position, target, step);
    }
}                             