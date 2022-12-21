using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWithTheFlow : MonoBehaviour
{
    // 50 units of force translates to 1 unit of distance per second per second.
    [SerializeField]
    private float Force = 10f;

    private void OnCollisionStay(Collision collision)
    {
        //collision.gameObject.GetComponent<Rigidbody>().AddForce((transform.forward * Force) * Time.deltaTime , ForceMode.Acceleration );
        float conveyorVelocity = Force * Time.deltaTime;
        var r_body = collision.gameObject.GetComponent<Rigidbody>();
        r_body.velocity = conveyorVelocity * transform.forward;
        //r_body.AddForceAtPosition(conveyorVelocity * transform.forward, new Vector3(0,0,0) , ForceMode.VelocityChange);
        //r_body.freezeRotation = true;
    }



    private void OnCollisionExit(Collision collision)
    {
        var r_body = collision.gameObject.GetComponent<Rigidbody>();
       // r_body.freezeRotation = false;
    }

    private void Update()
    {
        gameObject.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", gameObject.GetComponent<Renderer>().material.GetTextureOffset("_MainTex") + new Vector2(0, Force/100) *Time.deltaTime);
    }


}
