using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float Speed;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
       

        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Horizontal"))
        {
            transform.position = transform.position + transform.right * Input.GetAxis("Horizontal") * Time.deltaTime * Speed;

            // roteren inplaats van verplaatsen
            //transform.rotation = new Quaternion(transform.rotation.x , transform.rotation.y + Time.deltaTime * Input.GetAxis("Horizontal") , transform.rotation.z, transform.rotation.w); 
            //rb.AddTorque(  new Vector3(0, Input.GetAxis("Horizontal")*3, 0) , ForceMode.Force); //with force is also fun (je hebt een Rigidbody nodig hier voor (er staat er een op normaal)
        }
        if (Input.GetButton("Vertical"))
        {
            transform.position = transform.position + transform.forward * Input.GetAxis("Vertical") * Time.deltaTime * Speed;
            //rb.AddForce(transform.forward * Input.GetAxis("Vertical") * Speed, ForceMode.Force); //with force is also fun
        }
    }
}
