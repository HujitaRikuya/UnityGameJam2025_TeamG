using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimerUI : MonoBehaviour
{
    TextMeshProUGUI timer_TMP;

    public GameTimer Game_Timer;
    // Start is called before the first frame update
    void Start()
    {
        timer_TMP = GetComponent<TextMeshProUGUI>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
