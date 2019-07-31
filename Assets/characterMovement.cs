using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class characterMovement : MonoBehaviour {
	public float sd;
	private Rigidbody2D rb;

	void Start()
	{
		rb = GetComponent<Rigidbody2D> ();

	}

	void Update()
	{
		float movH = Input.GetAxis ("Horizontal");
		float movV = Input.GetAxis ("Vertical");
		Vector2 move = new Vector2 (movH, movV);
		rb.AddForce (move * sd);
	}
}
