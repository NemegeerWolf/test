using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private Material[] materials;

    [SerializeField]
    private GameObject prefabe;

    private float time;

    private void Update()
    {
        time += Time.deltaTime;

        if (time >= 2)
        {
            time = 0;
            var p = Instantiate(prefabe, transform.position, prefabe.transform.rotation);
            p.GetComponent<MeshRenderer>().material = materials[Random.Range(0, materials.Length)];
        }
    }
    
}
