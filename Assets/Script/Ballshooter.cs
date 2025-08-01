using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballshooter : MonoBehaviour
{
    public GameObject ballPrefab; // ボールのプレハブ
    public Transform shootPoint; // ボールを発射する位置
    public float shootForce = 500f; // ボールに加える力
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            ShootBall();
        }
    }

    void ShootBall()
    {
        // ボールを生成
        GameObject ball = Instantiate(ballPrefab, shootPoint.position, Quaternion.identity);
        // ボールに力を加える
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.AddForce(shootPoint.forward * shootForce);
        
    }
}

public class AutoDestroyByDistance : MonoBehaviour
{
    // 消えるまでの最大距離（インスペクターで設定可能）
    public float maxDistance = 1f;

    // 球が発射された時の位置を保存する変数
    private Vector3 startPos;

    // 最初に1回だけ実行される関数（初期化処理）
    void Start()
    {
        // 球が出現した位置を記録
        startPos = transform.position;
    }

    // 毎フレーム呼ばれる関数（距離をチェックする）
    void Update()
    {
        // 現在位置と最初の位置との距離を計算
        float distance = Vector3.Distance(startPos, transform.position);

        // その距離が最大距離を超えたら、球を消す
        if (distance > maxDistance)
        {
            // このGameObject（＝球）を削除する
            Destroy(gameObject);
        }
    }
}
