using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public GameObject bulletPrefab; // �e�̃v���n�u
    public Transform firePoint; // �e�𔭎˂���ʒu
    public float shootInterval = 2f; // �e�𔭎˂���Ԋu

    private Transform Player; // �v���C���[�̈ʒu
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player")?.transform; // �v���C���[���^�O�Ŏ擾
        InvokeRepeating(nameof(Shoot),1f, shootInterval); // ����I��Shoot���\�b�h���Ăяo��
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Shoot()
    {
        if (Player != null || bulletPrefab == null || firePoint == null) return;
        // �v���C���[�����݂��A�e�̃v���n�u�Ɣ��ˈʒu���ݒ肳��Ă���ꍇ�ɒe�𔭎�
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity); // �e�𐶐�
        Vector3 dir = (Player.position - firePoint.position).normalized; // �v���C���[�̕������v�Z
        bullet.GetComponent<Rigidbody2D>().velocity = dir * 5f; // �e�̑��x��ݒ�
    }
}
