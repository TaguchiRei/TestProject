using UnityEngine;

public class Pendulum : MonoBehaviour
{
    [Tooltip("プレイヤーのオブジェクトを入れる")]
    [SerializeField] GameObject _player;
    float _playerRotation = 0;

    bool _playerOn = false;

    private void Update()
    {
        RaycastHit hit;
        var ray = Physics.Raycast(transform.position, transform.up * -1, out hit);
        if (hit.collider.gameObject.CompareTag("Player"))
        {
            transform.eulerAngles = new Vector3(0, hit.collider.transform.eulerAngles.y, 0);
        }
    }
}
