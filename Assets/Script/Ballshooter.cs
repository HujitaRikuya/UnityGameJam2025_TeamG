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