using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gui : MonoBehaviour {

    private float timerValue;
    public Text timer;
    public int SURVIVE_FOR;

    private void Start()
    {
        timer = GetComponent<Text>();
    }

    void Update()
    {
        timerValue += Time.deltaTime;
        timer.text = "Survive: " + Mathf.RoundToInt(timerValue);

        if (Mathf.RoundToInt(timerValue) == SURVIVE_FOR)
        {
            timer.text = "You have won!";
            Debug.Log("Victory");
            Time.timeScale = 0.0f;
        }
    }
}
