using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3f;
    public int minEnemies = 1;
    public int maxEnemies = 4;

    // 出現範囲を設定（Xは画面右外固定、Y/Zはランダム）
    public float spawnX = 10f; // X軸：画面右外
    public float spawnYMin = -3f;
    public float spawnYMax = 3f;
    public float spawnZMin = -5f;
    public float spawnZMax = 5f;
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemies), 2f, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemies()
    {
        int count = Random.Range(minEnemies, maxEnemies + 1);
        for (int i = 0; i < count; i++)
        {
            Vector3 spawnPos = new Vector3(
                spawnX,
                Random.Range(spawnYMin, spawnYMax),
                Random.Range(spawnZMin, spawnZMax)
            );

            GameObject enemy = Instantiate(enemyPrefab, spawnPos, Quaternion.identity);

            // 必要なら向きも変える（例：Z軸マイナス方向へ向かせる）
            enemy.transform.rotation = Quaternion.LookRotation(Vector3.back);
        }
    }
}
