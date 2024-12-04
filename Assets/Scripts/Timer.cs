using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI txt;
    public static float counter = 10f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        txt = GetComponent<TextMeshProUGUI>();
        counter -= Time.deltaTime;
        txt.text = "Time Left: " + Mathf.Round(counter);
        if (counter <= 0)
        {
            Time.timeScale = 0;
        }
    }
}