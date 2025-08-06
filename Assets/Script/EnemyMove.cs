using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public float movespeed = 2f; // �G�̈ړ����x
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(0f, 180f, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * movespeed * Time.deltaTime;

        Delete(); // ��ʊO�ɏo����폜
    }

    // ��ʊO�ɏo����폜
    private void Delete()
    {
        if (this.transform.position.z    < -55) // ��ʂ̊O�ɏo����폜
        {
            Destroy(this.gameObject);
        }
    }
}
