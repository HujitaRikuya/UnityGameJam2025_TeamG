using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float lifeTime = 5f; // �e�̎���
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime); // �w�肵�����Ԍ�ɒe���폜
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // �e�����̃I�u�W�F�N�g�ɓ��������Ƃ��̏���
        if (other.CompareTag("Player"))
        {
            // �v���C���[�ɓ�����������
            Destroy(gameObject);
        }
    }
}
