using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class stopWatch : MonoBehaviour
{
    public float timeStart;
    public TextMeshProUGUI timeText;
    
    bool timerActive = false;
    
    // Start is called before the first frame update
    void Start()
    {
        timeText.text = timeStart.ToString("F2");
    }

    // Update is called once per frame
    void Update()
    {
        if (timerActive)
        {
            timeStart += Time.deltaTime;
            timeText.text = timeStart.ToString("F2");
        }
    
    }
    public void timerButton() {
        timerActive = !timerActive;
    }
}
