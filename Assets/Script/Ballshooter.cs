using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballshooter : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform shootPoint;
    public float shootForce = 1000f;
    public float cooldownTime = 1f;     // �� �N�[���^�C���̒����i�b�j
    private float lastShootTime = -Mathf.Infinity; // �Ō�Ɍ����������i�����l�F�����O�j
    // Start is called before the first frame update
    void Start()
    {
      
    }

    public void TryShoot()
    {
        if (Time.time - lastShootTime >= cooldownTime)
        {
            ShootBall();
            lastShootTime = Time.time;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastShootTime >= cooldownTime)
        //{
        //    ShootBall();
        //    lastShootTime = Time.time; // �Ō�Ɍ������������X�V
        //}
    }

    void ShootBall()
    {
        //���𔭎ˈʒu�ɐ��� 
        GameObject ball = Instantiate(ballPrefab, shootPoint.position, shootPoint.rotation);
        // Rigidbody�R���|�[�l���g���擾���ė͂�������
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.useGravity = false; // ���Ƃ������Ȃ��Ȃ�ON�ɂ��Ȃ�
        rb.AddForce(shootPoint.forward * shootForce);
    }
}
