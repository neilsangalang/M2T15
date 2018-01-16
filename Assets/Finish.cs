using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {

    Material material;
	void Start () {
        material = GetComponent<Renderer>().material;
	}

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Collided with Finish!");
            material.color = Color.red;
        }

    }
}
