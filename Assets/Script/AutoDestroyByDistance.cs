using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoDestroyByDistance : MonoBehaviour
{
    // ������܂ł̍ő勗���i�C���X�y�N�^�[�Őݒ�\�j
    public float maxDistance = 20f;

    // �������˂��ꂽ���̈ʒu��ۑ�����ϐ�
    private Vector3 startPos;

    // Start is called before the first frame update
    void Start()
    {
        // �����o�������ʒu���L�^
        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // ���݈ʒu�ƍŏ��̈ʒu�Ƃ̋������v�Z
        float distance = Vector3.Distance(startPos, transform.position);

        // ���̋������ő勗���𒴂�����A��������
        if (distance > maxDistance)
        {
            // ����GameObject�i�����j���폜����
            Destroy(gameObject);
        }
    }
}
