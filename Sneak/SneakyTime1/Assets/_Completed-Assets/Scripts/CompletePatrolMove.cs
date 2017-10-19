using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletePatrolMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        transform.position += transform.up * Time.deltaTime * 3;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        //Check the provided Collider2D parameter other to see if it is tagged "PickUp", if it is...
        if (other.gameObject.CompareTag("Wall") || other.gameObject.CompareTag("Background"))
        {
            transform.Rotate(new Vector3(0, 0, 180));
        }
    }
}
