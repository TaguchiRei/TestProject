using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private void FixedUpdate()
    {
        var rotate = Input.GetAxisRaw("Horizontal");
        var going = Input.GetAxisRaw("Vertical");
        transform.position += transform.forward * going * 0.1f;
        transform.Rotate(0, rotate * 2f, 0);
    }
}
static public class Data
{
    public const float range = 8f;
    public const float cosAlpha = 0.85f;
}
