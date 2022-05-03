using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class stopWatch2 : MonoBehaviour
{
    public float timeStart2;
    public TextMeshProUGUI timeText2;
    
    bool timerActive2 = false;
    
    // Start is called before the first frame update
    void Start()
    {
        timeText2.text = timeStart2.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive2)
        {
            timeStart2 += Time.deltaTime;
            timeText2.text = timeStart2.ToString("F2");
        }
    
    }
    public void timer2Button() {
        timerActive2 = !timerActive2;
    }
}
