using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField]
    private Color ColorTopLeft;
    [SerializeField]
    private Color ColorTopRight;
    [SerializeField]
    private Color ColorBottomLeft;
    [SerializeField]
    private Color ColorBottomRight;

    [SerializeField]
    private Material MatCube;

    [SerializeField]
    private Camera cam;

    // Update is called once per frame
    void Update()
    {
        var mp = cam.WorldToViewportPoint(transform.position);

        var c1 = Color.Lerp(ColorTopLeft, ColorTopRight, mp.x);
        var c2 = Color.Lerp(ColorBottomLeft, ColorBottomRight, mp.x);

        MatCube.color = Color.Lerp(c2, c1, mp.y);

    }
}
