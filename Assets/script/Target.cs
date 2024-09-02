using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Target : MonoBehaviour
{
    [SerializeField] Transform player;
    Vector3 tpos;
    float tr = Data.range;
    float dot;
    private void Start()
    {
        tpos = this.transform.position;
    }
    private void FixedUpdate()
    {
        var pf = player.forward;
        if ((player.position.x - tpos.x) * (player.position.x - tpos.x) + (player.position.z - tpos.z) * (player.position.z - tpos.z) < tr * tr)
        {
            dot = Vector3.Dot(pf,(tpos-player.position).normalized);
            if(Data.cosAlpha <dot)
            {
                this.GetComponent<Renderer>().material.color = Color.red;
            }
            else
            {
                this.GetComponent<Renderer>().material.color= Color.white;
            }
        }
        else
        {
            this.GetComponent<Renderer>().material.color = Color.white;
        }
    }
}
