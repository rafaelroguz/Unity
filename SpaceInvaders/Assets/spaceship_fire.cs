using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spaceship_fire : MonoBehaviour {

    public Rigidbody2D bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            Rigidbody2D bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody2D;
            bulletInstance.AddForce(new Vector2(0, bulletSpeed));
        }
    }

}
