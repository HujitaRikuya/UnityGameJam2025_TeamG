using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    // �����ƕ����I�ɂԂ������Ƃ��ɌĂ΂��
    private void OnCollisionEnter(Collision collision)
    {
        // �Ԃ���������̃^�O�� "Enemy" ���m�F
        if (collision.gameObject.CompareTag("Player"))
        {
            // Enemy������
            Destroy(collision.gameObject);
            // �����i���j������
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
