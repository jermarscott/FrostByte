using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoseCondition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //initialize needed variables

    }

    // Update is called once per frame
    void Update()
    {
    
    }


    void OnCollisionEnter(Collision player)
    {
        // did object tagged "Enemy collider connect with player collider
        // if so
        //trigger lose screen being visable

        if (player.collider.tag == ("Player"))
        {
            Debug.Log("You Lose::GAMEOVER");
            

        }
    }
}
