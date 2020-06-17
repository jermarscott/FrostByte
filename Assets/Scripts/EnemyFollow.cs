using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{


    public float speed;
    public object direction;
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        // direction = (nextwayPoint.position - currentPosition).normalized;
        //direction = (target.transform.position-transform.position).normalized;
        //transform.position = Vector2.MoveTowards(transform.position,target.position, speed * Time.deltaTime);

      //  movement.x = Input.GetAxisRaw("Horizontal");
      //  movement.y = Input.GetAxisRaw("Vertical");
      //
      //  animator.SetFloat("Horizontal", movement.x);
      //  animator.SetFloat("Vertical", movement.y);
      //  animator.SetFloat("New Float 0", movement.sqrMagnitude);

    }

}
