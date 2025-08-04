using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ballshooter : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform shootPoint;
    public float shootForce = 1000f;
    public float cooldownTime = 1f;     // ← クールタイムの長さ（秒）
    private float lastShootTime = -Mathf.Infinity; // 最後に撃った時刻（初期値：無限前）
    // Start is called before the first frame update
    void Start()
    {
      
    }

    public void TryShoot()
    {
        if (Time.time - lastShootTime >= cooldownTime)
        {
            ShootBall();
            lastShootTime = Time.time;
        }
    }
    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space) && Time.time - lastShootTime >= cooldownTime)
        //{
        //    ShootBall();
        //    lastShootTime = Time.time; // 最後に撃った時刻を更新
        //}
    }

    void ShootBall()
    {
        //球を発射位置に生成 
        GameObject ball = Instantiate(ballPrefab, shootPoint.position, shootPoint.rotation);
        // Rigidbodyコンポーネントを取得して力を加える
        Rigidbody rb = ball.GetComponent<Rigidbody>();
        rb.useGravity = false; // 落としたくないならONにしない
        rb.AddForce(shootPoint.forward * shootForce);
    }
}
