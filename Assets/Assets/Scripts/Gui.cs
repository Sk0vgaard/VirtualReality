using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gui : MonoBehaviour {

    private float timerValue;
    public Text timer;

    private void Start()
    {
        timer = GetComponent<Text>();
    }

    void Update()
    {
 
        timerValue += Time.deltaTime;
        timer.text = "survive: " + Mathf.RoundToInt(timerValue);
        if (Mathf.RoundToInt(timerValue) == 20)
        {
            Debug.Log("Victory");
        }
    }
}
