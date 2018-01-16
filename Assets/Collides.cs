using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collides : MonoBehaviour {



	void OnCollisionEnter (Collision col)
	{
		if (col.gameObject.tag == "pipe")
		{
            Debug.Log("Collided with Pipe!");
			SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
		}

        if (col.gameObject.tag == "finish")
        {
            Debug.Log("You win!");
        }
    }


}
