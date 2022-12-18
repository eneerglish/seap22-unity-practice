using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScore : MonoBehaviour
{
    private Text scoreText = null;
    private float totalTime = 0f;
    private int seconds = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = this.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        totalTime += Time.deltaTime;
        seconds = (int)totalTime;
        scoreText.text = seconds.ToString();
    }
}
