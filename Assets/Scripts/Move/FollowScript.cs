using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowScript : MonoBehaviour
{
    [SerializeField]
    private Transform PlayerToFollow;
    [SerializeField]
    private float Speed;
    [SerializeField]
    private Vector3 Offset;

    
    

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(PlayerToFollow);
        var playerposition = PlayerToFollow.position;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3( playerposition.x+Offset.x, playerposition.y+Offset.y, playerposition.z + Offset.z) , Time.deltaTime * Speed);
    }
}
