using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeda : MonoBehaviour
{
    public float MoveSpeed = 0.01f;
    public GameObject ballPrefab;
    public float shootForce = 500f;
    public Transform shootPoint;//���ˈʒu�i�v���C���[�̑O�j
   //�����shootPoint��ݒ肷�邱�ƂŁA�{�[�����v���C���[�̑O�ɔ��˂����悤�ɂ���

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // �ړ����x��������
        Vector3 move = Vector3.zero;


        //// �O��ړ�
        //if (Input.GetKey(KeyCode.W))
        //{
        //    move.z += MoveSpeed;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    move.z += -MoveSpeed;
        //}
        // ���E�ړ�
        if (Input.GetKey(KeyCode.D))
        {
            move.x += MoveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move.x += -MoveSpeed;
        }


        // �ړ�������
        transform.position += move;

        if(Input.GetKeyDown(KeyCode.Space))
        {
           shootBall();
        }
    }

    void shootBall()
    {
        // �{�[���𐶐�
        GameObject ball = Instantiate(ballPrefab, shootPoint.position, Quaternion.identity);
        // �{�[���ɗ͂�������
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(shootPoint.forward * shootForce);
        }
    }
}
