using UnityEngine;

public class converbelt : MonoBehaviour
{
    [SerializeField]
    private Rigidbody rigidbody = null;

    [SerializeField]
    private float Force = 10f;


    void FixedUpdate()
    {
        Vector3 pos = rigidbody.position;
        rigidbody.position = pos + -rigidbody.transform.forward * Force * Time.deltaTime;
        rigidbody.MovePosition(pos);
        
        gameObject.GetComponent<Renderer>().material.SetTextureOffset("_MainTex", gameObject.GetComponent<Renderer>().material.GetTextureOffset("_MainTex") + new Vector2(0, Force / transform.localScale.z*10 ) * Time.deltaTime);
    }
}
