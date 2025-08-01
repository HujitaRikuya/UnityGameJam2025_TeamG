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