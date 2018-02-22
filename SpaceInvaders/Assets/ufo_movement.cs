using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo_movement : MonoBehaviour {

    private const int yPosition = 4;
    float maxValue = 11; 
    float minValue = -11; 
    public float currentValue; 
    int direction = 1;
    public int speed;

    void Start () {
        
	}
	
	void Update () {
        currentValue += Time.deltaTime * direction * speed;

        if (currentValue >= maxValue)
        {
            direction *= -1;
            currentValue = maxValue;
        }
        else if (currentValue <= minValue)
        {
            direction *= -1;
            currentValue = minValue;
        }

        transform.position = new Vector2(currentValue, yPosition);

        //transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
}
