using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineGenerator : MonoBehaviour
{
    LineRenderer line;
    GameObject Hoge;
    GameObject Puke;

    // Start is called before the first frame update
    void Start()
    {
        this.Hoge = GameObject.Find("Hoge");
        this.Puke = GameObject.Find("Puke");

        //�R���|�[�l���g���擾����
        this.line = GetComponent<LineRenderer>();

        //���̕������߂�
        this.line.startWidth = 0.1f;
        this.line.endWidth = 0.1f;

        //���_�̐������߂�
        this.line.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Update�ɏ������͍̂�҂����I�ɕω�����������������
        //0��1�͒��_�̏���(����)
        line.SetPosition(0, Hoge.transform.position);
        line.SetPosition(1, Puke.transform.position);
    }
}