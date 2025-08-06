using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHit : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            // Playerのスクリプトを探して killCount を増やす
            Player player = FindObjectOfType<Player>();
            if (player != null)
            {
                player.EnemyCount++;
                Debug.Log("倒した数: " + player.EnemyCount);
            }

            // プレイヤーに当たったら自分を消す
            Destroy(gameObject);

            Destroy(other.gameObject); // プレイヤーも消す
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
