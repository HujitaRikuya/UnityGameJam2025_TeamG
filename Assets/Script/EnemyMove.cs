using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float movespeed = 2f; // 敵の移動速度
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0f, 180f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * movespeed * Time.deltaTime;

        Delete(); // 画面外に出たら削除
    }

    // 画面外に出たら削除
    private void Delete()
    {
        if (this.transform.position.z    < -55) // 画面の外に出たら削除
        {
            Destroy(this.gameObject);
        }
    }
}
