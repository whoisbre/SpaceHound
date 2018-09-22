using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {
    
    Image healthBar;
    public Canvas canvas;
    private GameObject gos;
    private CanvasGroup canvasgroup;

    float fullHealth = 100f;
    public static float health;

	void Start () {

        Time.timeScale = 1;
        healthBar = GetComponent<Image>();
        health = fullHealth;
        canvasgroup = canvas.GetComponentInChildren<CanvasGroup>();
	}

    void Update()
    {

        healthBar.fillAmount = health / fullHealth;

        if(health <= 0){
            //CanvasGroup canvasgroup = canvas.GetComponent<CanvasGroup>();
            canvasgroup.alpha = 1;
            Time.timeScale = 0;
        }

	}
}
