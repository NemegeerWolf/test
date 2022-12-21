using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpAndDown : MonoBehaviour
{
    [SerializeField]
    private float Amplitude = 2.5f;
    [SerializeField]
    private float Frequency = 0.2f;

    private float time;
    private Vector3 basePosition;

    [SerializeField]
    private Rigidbody rigidbody = null;

    private void Start()
    {
        basePosition = rigidbody.position;
    }   

    void FixedUpdate()
    {
        time += Time.deltaTime;

        
            
           // float size = Mathf.Clamp((Amplitude * Mathf.Sin(time * Frequency))/ (basePosition.y + Amplitude), basePosition.y, basePosition.y+Amplitude);
            

        float size = basePosition.y + ((Mathf.Sin(time * Frequency)) + 1) * Amplitude / 2;
        Debug.Log(size);
        rigidbody.MovePosition(new Vector3(transform.position.x, size, transform.position.z)) ;
            
        
    }
}
