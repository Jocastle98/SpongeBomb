using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{

    //���󰡾��� ��� ���� �� ����
    public Transform targetTr;
    //Main Camera �ڽ��� Transform ������Ʈ
    private Transform camTr;
    //���� ������κ��� ������ �Ÿ� 

    [Range(2.0f, 20.0f)] public float distance = 10.5f;

    //Y������ �̵��� ����
    [Range(0.0f, 10.0f)] public float height = 4.2f;

    //�����ӵ�
    public float damping = 10.0f;

    //smoothdamp���� ����� ����
    private Vector3 velocity = Vector3.zero;

    private float targetOffset = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        camTr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void LateUpdate()
    {
        Vector3 pos = camTr.position = targetTr.position //�÷��̾� ��ġ
                  + (-targetTr.forward * distance) //�÷��̾� �ڿ� �־���ϹǷ� -targetTr.forward�̴�.
                  + (Vector3.up * height);
        camTr.position = Vector3.SmoothDamp(
            camTr.position, //������ġ
            pos,            //��ǥ��ġ
            ref velocity,   //����ӵ�
            damping);       //��ǥ��ġ���� ���޽ð�

         camTr.LookAt(targetTr.position + (targetTr.up * targetOffset));

    }
}

