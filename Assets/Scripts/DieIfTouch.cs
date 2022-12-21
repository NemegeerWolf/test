using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieIfTouch : MonoBehaviour
{
    private void OnCollisionStay(Collision collision)
    {
        Destroy(collision.gameObject);
    }
}
