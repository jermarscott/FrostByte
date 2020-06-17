
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    //if enemy is spawned zoom out to reveal him and then zoom back in to only player
    void LateUpdate()
    {
        transform.position = target.position + offset;
    }



}
