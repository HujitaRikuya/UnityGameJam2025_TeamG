using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    //// �����ƕ����I�ɂԂ������Ƃ��ɌĂ΂��
    //private void OnCollisionEnter(Collision collision)
    //{
    //    // �Ԃ���������̃^�O�� "Enemy" ���m�F
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        // Enemy������
    //        Destroy(collision.gameObject);
    //        // �����i���j������
    //        Destroy(gameObject);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //// Player�̃X�N���v�g��T���� killCount �𑝂₷
            //Player player = FindObjectOfType<Player>();
            //if (player != null)
            //{
            //    player.killCount++;
            //    Debug.Log("�|������: " + player.killCount);
            //}

            Destroy(other.gameObject); // ��������
            Destroy(gameObject);       // �G������
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
