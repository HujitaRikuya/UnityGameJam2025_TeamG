using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject bulletPrefab; // 弾のプレハブ
    public Transform firePoint; // 弾を発射する位置
    public float shootInterval = 2f; // 弾を発射する間隔

    private Transform Player; // プレイヤーの位置
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player")?.transform; // プレイヤーをタグで取得
        InvokeRepeating(nameof(Shoot),1f, shootInterval); // 定期的にShootメソッドを呼び出す
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        if (Player != null || bulletPrefab == null || firePoint == null) return;
        // プレイヤーが存在し、弾のプレハブと発射位置が設定されている場合に弾を発射
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity); // 弾を生成
        Vector3 dir = (Player.position - firePoint.position).normalized; // プレイヤーの方向を計算
        bullet.GetComponent<Rigidbody2D>().velocity = dir * 5f; // 弾の速度を設定
    }
}
