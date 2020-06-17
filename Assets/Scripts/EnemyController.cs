using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    // public float speed = 3.0f;
    // public bool vertical;
    // public float changeTime = 3.0f;
    public GameObject player;
    Rigidbody2D rigidbody2D;
    //float timer;
    //int direction = 1;
    //public gameObject playerObject;

    private Animator animator;
    public Transform Player;

    void Start()
    {
         rigidbody2D = GetComponent<Rigidbody2D>();
      //  timer = changeTime;
        animator = GetComponent<Animator>();
      //  Vector2 preLocation = rigidbody2D.position;
      //  Vector2 player;

        
    }

    // Update is called once per frame
    void Update()
    {
        // timer -= Time.deltaTime;
        //
        // if (timer < 0)
        // {
        //     direction = -direction;
        //     timer = changeTime;
        // }

        //  Vector2 preLocation = rigidbody2D.position;
       //  Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        Vector2 player = Player.position;
         Vector2 enemy = rigidbody2D.velocity;
         //player =  (player - enemy) ;
        
           if (player.y > enemy.y )//UP
               {
            animator.SetFloat("hrizontal", 1);
            animator.SetFloat("Vertical", 0);
        }
           if (player.y < enemy.y)//DOWN
           {
            animator.SetFloat("hrizontal", -1);
            animator.SetFloat("Vertical", 0);
        }
           if (player.x < enemy.x)//RIGHT
           {
               animator.SetFloat("hrizontal", 0);
               animator.SetFloat("Vertical", 1);
           }
           if (player.x > enemy.x)//LEFT
           {
               animator.SetFloat("hrizontal", 0);
               animator.SetFloat("Vertical", -1);
           }
      //  Vector2 movement= rigidbody2D.velocity;
       // movement.x =movement.velocity;
       // movement.y = movement.velocity;

        //animator.SetFloat("hrizontal", movement.x);
        //animator.SetFloat("vertical", movement.y);
        //animator.SetFloat("New Float 0", movement.sqrMagnitude);


        // {
        //     position.y = position.y + Time.deltaTime * direction * speed;
        //     animator.SetFloat("hrizontal", 0);
        //     animator.SetFloat("vertical", direction);
        // }
        // else
        // {
        //     position.x = position.x + Time.deltaTime * direction * speed;
        //     animator.SetFloat("hrizontal", direction);
        //     animator.SetFloat("vertical", 0);
        // }

        //rigidbody2D.MovePosition(position);
    }

    void FixedUpdate()
    {
      // Vector2 preLocation = Player* time.DeltaTime;
    }

}