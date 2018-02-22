using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class render_line : MonoBehaviour {

    public GameObject gameObject1;
    public GameObject gameObject2;

    private LineRenderer line;

	// Use this for initialization
	void Start () {
        //Add line render to the GameObject
        line = this.gameObject.AddComponent<LineRenderer>();
        //Set de witdth of the LineRenderer
        line.SetWidth(0.05f, 0.05f);
        //Set the number of vertex for the LineRenderer
        line.SetVertexCount(2);
	}
	
	// Update is called once per frame
	void Update () {
		//Check if the GameObjects are not null
        if (gameObject1 != null && gameObject1 != null)
        {
            //Update position of the two vertex of the LineRenderer
            line.SetPosition(0, gameObject1.transform.position);
            line.SetPosition(1, gameObject2.transform.position);
        }
	}
}
