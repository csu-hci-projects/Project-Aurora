using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class stopWatch3 : MonoBehaviour
{
    public float timeStart3;
    public TextMeshProUGUI timeText3;
    
    bool timerActive3 = false;
    
    // Start is called before the first frame update
    void Start()
    {
        timeText3.text = timeStart3.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive3)
        {
            timeStart3 += Time.deltaTime;
            timeText3.text = timeStart3.ToString("F2");
        }
    
    }
    public void timer3Button() {
        timerActive3 = !timerActive3;
    }
}
