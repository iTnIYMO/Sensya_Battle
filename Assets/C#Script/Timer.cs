using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public GameObject score_object = null;
    public int score_num = 0;

    private void Update()
    {
        Text score_text = score_object.GetComponent<Text>();
        score_text.text = "Time:" + score_num;

        score_num += 1;
    }
}
