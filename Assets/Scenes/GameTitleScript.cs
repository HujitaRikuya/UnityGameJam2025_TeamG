using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public string SceneName;

    void Update()
    {
        //スペースキーを押したらシーンを切り替える
      if(Input.GetKey(KeyCode.Space))
        {
            Debug.Log("シーンチェンジ");
            SceneManager.LoadScene(SceneName);
        }
    }
}
