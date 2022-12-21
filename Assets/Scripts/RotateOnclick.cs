using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateOnclick : MonoBehaviour
{
    [SerializeField]
    private Camera cam;

    [SerializeField]
    private LayerMask Mask;

    private bool opening = false;

    private GameObject SelectedgameObject;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out var hit, cam.farClipPlane, Mask))

            {
                Debug.Log("Hit ->" + hit.collider.gameObject.name);
                SelectedgameObject = hit.collider.gameObject;

                Debug.Log(transform.rotation);

                if (SelectedgameObject == gameObject)
                    opening = !opening;

            }
            else
            {
                Debug.Log("No Hit");
            }

            
        }

        if (SelectedgameObject == gameObject)
        {
            if (opening) 
                
                transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0, -45, 0), 90 *Time.deltaTime);
                //transform.transform.Rotate(0, -60, 0);
            else
                transform.rotation = Quaternion.RotateTowards(transform.rotation, new Quaternion(0, 0, 0, 1), 90 * Time.deltaTime);
            // transform.transform.Rotate(0, 60, 0);
        }
    }
}
