using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour {

    Rigidbody _rigidbody;
    int speed = 80; //8 for nomer's

    // Use this for initialization
    void Start () {
        _rigidbody = GetComponent<Rigidbody>();
    }
	
	void Update () {
        ProcessInput();   
	}

    
    private void ProcessInput()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            if (_rigidbody.velocity.magnitude > 10)
            {
                _rigidbody.velocity = _rigidbody.velocity.normalized * 10;
            }
            _rigidbody.AddRelativeForce(Vector3.up * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * speed * Time.deltaTime);

        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * speed * Time.deltaTime);
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            Debug.Log("Collided with Finish!");
            _rigidbody.velocity = _rigidbody.velocity.normalized;
        }

    }
}
