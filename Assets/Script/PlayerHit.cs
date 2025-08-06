using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHit : MonoBehaviour
{
    public int PlayerHitPoint = 3; // プレイヤーのHP（初期値3）
    public float invincibleTime = 1.0f; // 無敵時間（秒）

    private bool isInvincible = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy") && !isInvincible)
        {   
            PlayerHitPoint--;

            Debug.Log("Player hit! HP: " + PlayerHitPoint);

            if (PlayerHitPoint <= 0)
            {
                Destroy(gameObject); // HPが0になったら消滅
            }

            StartCoroutine(InvincibilityCoroutine());
            // 無敵時間中は敵からのダメージを受けない
            Destroy(other.gameObject); // Enemyも消す（必要なければ削除）
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
