using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            // Player�̃X�N���v�g��T���� killCount �𑝂₷
            Player player = FindObjectOfType<Player>();
            if (player != null)
            {
                player.EnemyCount++;
                Debug.Log("�|������: " + player.EnemyCount);
            }

            // �v���C���[�ɓ��������玩��������
            Destroy(gameObject);

            Destroy(other.gameObject); // �v���C���[������
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
