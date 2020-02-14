using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text timerText;
    public bool startTimer = true;
    public float time=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {
            time += Time.deltaTime;
            timerText.text =string.Format("Timer:{0} Seconds", time.ToString("0.0"));
        }
    }
}
