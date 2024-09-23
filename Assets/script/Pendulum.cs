using UnityEngine;

public class Pendulum : MonoBehaviour
{
    [SerializeField] Transform _fulcrum;
    public float distanceForFulcrum = 5;
    [SerializeField] float _runoutStrength = 1;
    [SerializeField] Rigidbody _rig;
    private void FixedUpdate()
    {
        transform.LookAt(_fulcrum);
        float gravityPower = 9.81f * _runoutStrength * -1;
        float dis = Vector3.Distance(_fulcrum.position, transform.position);
        float addPower = Mathf.Floor((dis - distanceForFulcrum));
        if (transform.position.y > _fulcrum.position.y)
        {
            addPower *= -1;
        }
        Vector3 gravity = new(0, gravityPower, 0);
        Vector3 rope = transform.TransformDirection(0, 0, gravityPower * -1);
        Vector3 setPos = new(0,addPower,0);
        _rig.AddForce(gravity + rope + setPos, ForceMode.Acceleration);
    }
}
