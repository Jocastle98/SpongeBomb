using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Enemy : MonoBehaviour
{


    // ������Ʈ�� ������ ����
    private Transform tr;
    private Rigidbody rb;

    // �Ѿ� ���� Ƚ���� ������ų ����
    private int hitcount = 0;

    // Start is called before the first frame update
    void Start()
    {
        tr = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();
        
    }

    // �浹 �� �߻��ϴ� �ݹ� �Լ�
    void OnCollisionEnter(Collision coll)
    {
        if (coll.collider.CompareTag("Bullet"))
        {
            // �Ѿ� ���� Ƚ���� ������Ű�� 3ȸ�̻��̸� ����ó��
            if (++hitcount == 3)
            {
                Destroy(gameObject, 1.0f);
            }
        }
    }



 
    void Update()
    {

    }
}
