using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyByDistance : MonoBehaviour
{
    // 消えるまでの最大距離（インスペクターで設定可能）
    public float maxDistance = 20f;

    // 球が発射された時の位置を保存する変数
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        // 球が出現した位置を記録
        startPos = transform.position;
    }

    // Update is called once per frame
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
