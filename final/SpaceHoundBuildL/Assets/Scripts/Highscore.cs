using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour {

    public float score = 0.0f;
    public float speed = 5.0f;
    public float hscore = 0f;

    public Text sc;
    public Text highsc;
    

    void Awake () {

    }

    // Update is called once per frame
    void Update()
    {
        hscore = PlayerPrefs.GetFloat("Highscore");
        highsc.text = "HIGHSCORE:       " + ((int)hscore).ToString();


        score += Time.deltaTime * speed;
        sc.text = "SCORE:               " + ((int)score).ToString();
        hscore = PlayerPrefs.GetFloat("Highscore");


        if (score > hscore)
        {
            PlayerPrefs.SetFloat("Highscore", score);
            PlayerPrefs.Save();
        }

        if (Input.GetKeyDown(KeyCode.R))
            PlayerPrefs.DeleteKey("Highscore");

    }
}
