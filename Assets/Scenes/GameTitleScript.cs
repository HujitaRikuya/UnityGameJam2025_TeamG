using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string SceneName;

    void Update()
    {
        //�X�y�[�X�L�[����������V�[����؂�ւ���
      if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("�V�[���`�F���W");
            SceneManager.LoadScene(SceneName);
        }
    }
}
