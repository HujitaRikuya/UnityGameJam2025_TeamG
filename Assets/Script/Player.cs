using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 0.01f;
    public float MaxYDistance = 10f; // ���S����ړ��ł���ő勗��
    public float MaxZDistance = 10f;
    public Vector3 CenterPoint = Vector3.zero; // ���S���W
    public GameObject ballPrefab;
        public float shootForce = 500f;
    public Transform shootPoint; // ���ˈʒu�i�v���C���[�̑O�Ȃǁj
    // Start is called before the first frame update    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // �ړ����x��������
        Vector3 move = Vector3.zero;


        // �O��ړ�
        if (Input.GetKey(KeyCode.W))
        {
            move.y += MoveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move.y += -MoveSpeed;
        }
        // ���E�ړ�
        if (Input.GetKey(KeyCode.D))
        {
            move.z += MoveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move.z += -MoveSpeed;
        }


        // �ړ���̍��W�̌v�Z
        Vector3 nextPos = transform.position + move;

        // ���S�_����̊e�����Ƃ̋������m�F
        float yDistance = Mathf.Abs(nextPos.y - CenterPoint.y);
        float zDistance = Mathf.Abs(nextPos.z - CenterPoint.z);

        // ���ꂼ��̎������e�͈͓����𔻒�
        bool withinY = yDistance <= MaxYDistance;
        bool withinZ = zDistance <= MaxZDistance;

        if (withinY && withinZ)
        {
            transform.position = nextPos;
        }
    

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // ���ˏ�����Ballshooter�ɔC���邽�߁A�Ăяo������
            GetComponent<Ballshooter>().TryShoot();
        }


    }

    //void ShootBall()
    //{
    //    GameObject ball = Instantiate(ballPrefab, shootPoint.position, shootPoint.rotation);
    //    Rigidbody rb = ball.GetComponent<Rigidbody>();
    //    rb.AddForce(shootPoint.forward * shootForce);
    //}
}

