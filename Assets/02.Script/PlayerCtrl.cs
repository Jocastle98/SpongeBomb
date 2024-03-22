using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{


    private float h = 0.0f;
    private float v = 0.0f;

    private Transform tr;           //�����ؾ��ϴ� ������Ʈ�� �ݵ�� ������ �Ҵ� �� ���
    public float moveSpeed = 10.0f; // �̵��ӵ� ����


    public float rotSpeed = 1.0f; //ȸ���ӵ� ����

    private Animation anim;

    void Start()
    {
        //��ũ��Ʈ ó���� Transform������Ʈ �Ҵ�
        tr = GetComponent<Transform>();
        //�ִϸ��̼� ����
      //  anim = GetComponent<Animation>();
       // anim.Play("Idle");
    }

    // Update is called once per frame
    void Update()
    {
        h = Input.GetAxis("Horizontal");    //A,D,Left,RightŰ�� �������� ��
        v = Input.GetAxis("Vertical");//-1~1          //W,D ,Up, DownŰ�� ������ ��
                                      //(0,0,0.5) + ( -0.5,0,0) = > (-0.5,0,0.5)

        //�����¿� �̵� ���� ���� ���
        //Vector3 moveDir = (Vector3.forward * v) + (Vector3.right * h);

        //Translate(�̵����� *�ӵ�*���� �� *TimedeltaTime, ������ǥ
       // tr.Translate(moveDir.normalized * Time.deltaTime * moveSpeed, Space.Self);

        //Vector3.up ���� �������� rotSpeed��ŭ�� �ӵ��� ȸ��


        tr.Rotate(Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));

        //���ΰ� ĳ������ �ִϸ��̼� ����
      //  PlayerAnim(h, v);

    }

   /* void PlayerAnim(float h, float v)
    {

        //Ű���� �Է°� �������� ���� �ִϸ��̼� ����
        if (v >= 0.1f)
        {
            anim.CrossFade("RunF", 0.25f); //�����ִϸ��̼� , 0.25�� �������� ��ġ�� ����

        }
        else if (v <= -0.1f)
        {
            anim.CrossFade("RunB", 0.25f); //����
        }

        else if (h >= 0.1f)
        {
            anim.CrossFade("RunR", 0.25f); //����
        }
        else if (h <= -0.1f)
        {
            anim.CrossFade("RunB", 0.25f); //����
        }

        else
        {
            anim.CrossFade("Idle", 0.25f);//���� �� Idle �ִ� ����
        }

    }
*/
}
