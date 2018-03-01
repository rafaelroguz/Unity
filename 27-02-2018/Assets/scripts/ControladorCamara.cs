using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorCamara : MonoBehaviour {

    public GameObject esfera;
    private Vector3 desplazamiento;

    void Start()
    {
        desplazamiento = transform.position - esfera.transform.position;
    }

    void LateUpdate()
    {
        transform.position = esfera.transform.position + desplazamiento;
    }
}
