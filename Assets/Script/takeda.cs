using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class takeda : MonoBehaviour
{
    public float MoveSpeed = 0.01f;
    public GameObject ballPrefab;
    public float shootForce = 500f;
    public Transform shootPoint;//発射位置（プレイヤーの前）
   //これにshootPointを設定することで、ボールがプレイヤーの前に発射されるようにする

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // 移動速度を初期化
        Vector3 move = Vector3.zero;


        //// 前後移動
        //if (Input.GetKey(KeyCode.W))
        //{
        //    move.z += MoveSpeed;
        //}
        //if (Input.GetKey(KeyCode.S))
        //{
        //    move.z += -MoveSpeed;
        //}
        // 左右移動
        if (Input.GetKey(KeyCode.D))
        {
            move.x += MoveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move.x += -MoveSpeed;
        }


        // 移動させる
        transform.position += move;

        if(Input.GetKeyDown(KeyCode.Space))
        {
           shootBall();
        }
    }

    void shootBall()
    {
        // ボールを生成
        GameObject ball = Instantiate(ballPrefab, shootPoint.position, Quaternion.identity);
        // ボールに力を加える
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(shootPoint.forward * shootForce);
        }
    }
}
