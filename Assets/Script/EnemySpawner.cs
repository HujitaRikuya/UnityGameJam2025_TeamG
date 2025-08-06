using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 3f;
    public int minEnemies = 1;
    public int maxEnemies = 4;

    // �o���͈͂�ݒ�iX�͉�ʉE�O�Œ�AY/Z�̓����_���j
    public float spawnX = 10f; // X���F��ʉE�O
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

            // �K�v�Ȃ�������ς���i��FZ���}�C�i�X�����֌�������j
            enemy.transform.rotation = Quaternion.LookRotation(Vector3.back);
        }
    }
}
