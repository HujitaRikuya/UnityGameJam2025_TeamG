using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollision : MonoBehaviour
{
    // 何かと物理的にぶつかったときに呼ばれる
    private void OnCollisionEnter(Collision collision)
    {
        // ぶつかった相手のタグが "Enemy" か確認
        if (collision.gameObject.CompareTag("Player"))
        {
            // Enemyを消す
            Destroy(collision.gameObject);
            // 自分（球）も消す
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
