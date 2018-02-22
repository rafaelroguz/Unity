using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ufo_fire : MonoBehaviour {

    public Rigidbody2D bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;
    public float wait;

    void Start() {
        wait = 0;
    }

    void Update() {
        if (wait > 0)
        {
            wait = wait - Time.deltaTime;
        } else
        {
            Rigidbody2D bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody2D;
            bulletInstance.AddForce(new Vector2(0, bulletSpeed));
            wait = 1;
        }
	}
}
