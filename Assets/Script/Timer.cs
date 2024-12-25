using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject score_object = null;
    public float score_num = 0.0f;
    public int seconds = 0;

    private void FixedUpdate()
    {
        Text score_text = score_object.GetComponent<Text>();
        seconds = (int)score_num;
        score_text.text = "Time:" + seconds;
        score_num += 0.02f;
    }
}
