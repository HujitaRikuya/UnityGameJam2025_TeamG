using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public int PlayerHitPoint = 3; // �v���C���[��HP�i�����l3�j
    public float invincibleTime = 1.0f; // ���G���ԁi�b�j

    private bool isInvincible = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && !isInvincible)
        {   
            PlayerHitPoint--;

            Debug.Log("Player hit! HP: " + PlayerHitPoint);

            if (PlayerHitPoint <= 0)
            {
                Destroy(gameObject); // HP��0�ɂȂ��������
            }

            StartCoroutine(InvincibilityCoroutine());
            // ���G���Ԓ��͓G����̃_���[�W���󂯂Ȃ�
            Destroy(other.gameObject); // Enemy�������i�K�v�Ȃ���΍폜�j
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

    private System.Collections.IEnumerator InvincibilityCoroutine()
    {
        isInvincible = true;
        yield return new WaitForSeconds(invincibleTime);
        isInvincible = false;
    }
}
