using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballshooter : MonoBehaviour
{
    public GameObject ballPrefab; // �{�[���̃v���n�u
    public Transform shootPoint; // �{�[���𔭎˂���ʒu
    public float shootForce = 500f; // �{�[���ɉ������
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ShootBall();
        }
    }

    void ShootBall()
    {
        // �{�[���𐶐�
        GameObject ball = Instantiate(ballPrefab, shootPoint.position, Quaternion.identity);
        // �{�[���ɗ͂�������
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.AddForce(shootPoint.forward * shootForce);
        
    }
}

public class AutoDestroyByDistance : MonoBehaviour
{
    // ������܂ł̍ő勗���i�C���X�y�N�^�[�Őݒ�\�j
    public float maxDistance = 1f;

    // �������˂��ꂽ���̈ʒu��ۑ�����ϐ�
    private Vector3 startPos;

    // �ŏ���1�񂾂����s�����֐��i�����������j
    void Start()
    {
        // �����o�������ʒu���L�^
        startPos = transform.position;
    }

    // ���t���[���Ă΂��֐��i�������`�F�b�N����j
    void Update()
    {
        // ���݈ʒu�ƍŏ��̈ʒu�Ƃ̋������v�Z
        float distance = Vector3.Distance(startPos, transform.position);

        // ���̋������ő勗���𒴂�����A��������
        if (distance > maxDistance)
        {
            // ����GameObject�i�����j���폜����
            Destroy(gameObject);
        }
    }
}
