using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 0.01f;
    public float MaxYDistance = 10f; // 中心から移動できる最大距離
    public float MaxZDistance = 10f;
    public Vector3 CenterPoint = Vector3.zero; // 中心座標
    public GameObject ballPrefab;
        public float shootForce = 500f;
    public Transform shootPoint; // 発射位置（プレイヤーの前など）
    public int EnemyCount = 0;  // 倒した数
    // Start is called before the first frame update    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 移動速度を初期化
        Vector3 move = Vector3.zero;


        // 前後移動
        if (Input.GetKey(KeyCode.W))
        {
            move.y += MoveSpeed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            move.y += -MoveSpeed;
        }
        // 左右移動
        if (Input.GetKey(KeyCode.D))
        {
            move.z += MoveSpeed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            move.z += -MoveSpeed;
        }


        // 移動後の座標の計算
        Vector3 nextPos = transform.position + move;

        // 中心点からの各軸ごとの距離を確認
        float yDistance = Mathf.Abs(nextPos.y - CenterPoint.y);
        float zDistance = Mathf.Abs(nextPos.z - CenterPoint.z);

        // それぞれの軸が許容範囲内かを判定
        bool withinY = yDistance <= MaxYDistance;
        bool withinZ = zDistance <= MaxZDistance;

        if (withinY && withinZ)
        {
            transform.position = nextPos;
        }
    

        if (Input.GetKeyDown(KeyCode.Space))
        {
            // 発射処理をBallshooterに任せるため、呼び出すだけ
            GetComponent<Ballshooter>().TryShoot();
        }


    }

    //void ShootBall()
    //{
    //    GameObject ball = Instantiate(ballPrefab, shootPoint.position, shootPoint.rotation);
    //    Rigidbody rb = ball.GetComponent<Rigidbody>();
    //    rb.AddForce(shootPoint.forward * shootForce);
    //}
}

