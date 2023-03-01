using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class enemymovement : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 target;
    public Transform end;
   public float speed;
    public Transform start;
    void Start()
    {

        target = end.position;
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