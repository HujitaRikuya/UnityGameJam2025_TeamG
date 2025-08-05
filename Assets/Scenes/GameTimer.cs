using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class GameTimer : MonoBehaviour
{
    [SerializeField]private TextMeshProUGUI timer_TMP;
    private float m_maxTime=180f;
    float m_second;
    int m_minute;
    float minutes;
    float seconds;

    public float GetSecond()
    {
        return m_second;
    }
    public int GetMinute()
    {
        return m_minute;
    }
    
    void Update()
    {
        CalcTime();
        timer_TMP.text = $"Time {(int)minutes}:{(int)seconds}";
        //m_second += Time.deltaTime;
        //if(m_second >180.0f)
        //{
        //    m_minute++;
        //    m_second -= 180.0f;
        //}
    }

    private void CalcTime()
    {
        m_second += Time.deltaTime;
        float timeLimit = m_maxTime - m_second;

        minutes = timeLimit / 60;
        seconds = timeLimit % 60;
    }
}
