using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class stopWatch1 : MonoBehaviour
{
    public float timeStart1;
    public TextMeshProUGUI timeText1;
    
    bool timerActive1 = false;
    
    // Start is called before the first frame update
    void Start()
    {
        timeText1.text = timeStart1.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive1)
        {
            timeStart1 += Time.deltaTime;
            timeText1.text = timeStart1.ToString("F2");
        }
    
    }
    public void timer1Button() {
        timerActive1 = !timerActive1;
    }
}
