using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {

    public float score = 0.0f;
    public float speed = 5.0f;

    public Text sc;
    public Text highsc;

	void Start () {

        highsc.text = "HIGHSCORE     " + (int)PlayerPrefs.GetFloat("highscore");

	}

    // Update is called once per frame
    void Update()
    {

        score += Time.deltaTime * speed;
        sc.text = "Score     " + ((int)score).ToString();

        if (PlayerPrefs.GetFloat("highscore") < score)
        {
            PlayerPrefs.SetFloat("highscore", score);
        }

    }
}
