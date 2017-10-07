using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightChangeScript : MonoBehaviour {

    public float timer;
    private float direction;
    private Light light;
    private Gradient gradient;
    public float speed;

    // Use this for initialization
    void Start() {
        GradientColorKey[] gck;
        GradientAlphaKey[] gak;

        Color mygreen = new Color(15.0F / 255.0F, 116.0F / 255.0F, 11.0F / 255.0F);
        gradient = new Gradient();
        gck = new GradientColorKey[4];
        gck[0].color = mygreen;
        gck[0].time = 0.0F;
        gck[1].color = mygreen;
        gck[1].time = 1.5F / 5;
        gck[2].color = Color.red;
        gck[2].time = 3.5F / 5;
        gck[3].color = Color.red;
        gck[3].time = 1.0F;

        gak = new GradientAlphaKey[2];
        gak[0].alpha = 1.0F;
        gak[0].time = 0.0F;
        gak[1].alpha = 1.0F;
        gak[1].time = 1.0F;
        gradient.SetKeys(gck, gak);


        timer = 0;
        direction = 1;
        light = GetComponent<Light>();
        
	}
	
	// Update is called once per frame
	void Update () {
        timer += Time.deltaTime* direction;
        if (timer > 5)
        {
            direction = -1;
            timer = 5;
        }
        else if (timer < 0)
        {
            direction = 1;
            timer = 0;
        }
        light.color = gradient.Evaluate(timer / 5);
	}
}
