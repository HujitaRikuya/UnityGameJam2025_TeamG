using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    //// 何かと物理的にぶつかったときに呼ばれる
    //private void OnCollisionEnter(Collision collision)
    //{
    //    // ぶつかった相手のタグが "Enemy" か確認
    //    if (collision.gameObject.CompareTag("Enemy"))
    //    {
    //        // Enemyを消す
    //        Destroy(collision.gameObject);
    //        // 自分（球）も消す
    //        Destroy(gameObject);
    //    }
    //}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            //// Playerのスクリプトを探して killCount を増やす
            //Player player = FindObjectOfType<Player>();
            //if (player != null)
            //{
            //    player.killCount++;
            //    Debug.Log("倒した数: " + player.killCount);
            //}

            Destroy(other.gameObject); // 球を消す
            Destroy(gameObject);       // 敵を消す
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
