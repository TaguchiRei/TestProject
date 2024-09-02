using UnityEngine;

public class LineGenerate : MonoBehaviour
{
    [SerializeField] GameObject _target = default;
    [SerializeField] LineRenderer _line = null;
    private void FixedUpdate()
    {
        _line.SetPosition(0,_target.transform.position);
        _line.SetPosition(1,transform.position);
    }
}