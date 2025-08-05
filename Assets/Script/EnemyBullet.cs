using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float lifeTime = 5f; // 弾の寿命
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifeTime); // 指定した時間後に弾を削除
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // 弾が他のオブジェクトに当たったときの処理
        if (other.CompareTag("Player"))
        {
            // プレイヤーに当たった処理
            Destroy(gameObject);
        }
    }
}
