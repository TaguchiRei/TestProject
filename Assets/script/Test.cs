using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] bool _spaceDebug = true;

    private void Start()
    {
        Debug.Log("The program is attached successfully");
    }
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)&& _spaceDebug)
        {
            Debug.Log("SpaceKey");
        }
    }
}
