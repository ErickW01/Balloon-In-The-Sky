using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour 
{

	void OnTriggerEnter2D(Collider2D other)
	{

		if (other.tag == "cloud_or_barrier") {
			SceneManager.LoadScene ("Scene4");
		}
		if (other.tag == "finishline") {
			SceneManager.LoadScene ("Scene3");
		}
	}
}
