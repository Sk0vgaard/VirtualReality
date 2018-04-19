using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Gui : MonoBehaviour {

    private float timerValue;
    public Text timer;
    public int SURVIVE_FOR;

    private void Start()
    {
        timer = GetComponent<Text>();
        SURVIVE_FOR = 20;
    }

    void Update()
    {
        timerValue += Time.deltaTime;
        timer.text = "Time:  " + Mathf.RoundToInt(timerValue);

        if (Mathf.RoundToInt(timerValue) == SURVIVE_FOR)
        {
            timer.text = "You have won!";
            Time.timeScale = 0.0f;
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Debug.Log("ESC pressed");
            Cursor.visible = true;
            Time.timeScale = 0.0f;
            SceneManager.LoadScene(0);
        }
    }
}
