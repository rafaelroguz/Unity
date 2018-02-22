using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ship_collission : MonoBehaviour {

    void OnCollisionEnter(Collision collisionInfo)
    {
        Debug.Log("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        Debug.Log("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        Debug.Log("Their relative velocity is " + collisionInfo.relativeVelocity);
        print("Detected collision between " + gameObject.name + " and " + collisionInfo.collider.name);
        print("There are " + collisionInfo.contacts.Length + " point(s) of contacts");
        print("Their relative velocity is " + collisionInfo.relativeVelocity);
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        print(gameObject.name + " and " + collisionInfo.collider.name + " are still colliding");
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        print(gameObject.name + " and " + collisionInfo.collider.name + " are no longer colliding");
    }
}
