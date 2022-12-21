using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    [SerializeField]
    private int speed = 5;

    [SerializeField]
    private Camera cam;

    // Update is called once per frame
    void Update()
    {

        var mp = Input.mousePosition;
        mp.z = 10;
        transform.position = Vector3.Lerp(transform.position, cam.ScreenToWorldPoint(mp), speed * Time.deltaTime); 

            //+ new Vector3(0, -9.5f, 0);
    }
}
