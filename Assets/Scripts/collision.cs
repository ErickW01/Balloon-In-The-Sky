using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collision : MonoBehaviour 
{
    int curr_scene;

	void OnTriggerEnter2D(Collider2D other)
	{
        curr_scene = SceneManager.GetActiveScene().buildIndex;
        print(curr_scene); //Fix after making more levels


		if (other.tag == "cloud_or_barrier") {
			SceneManager.LoadScene ("Failure");
		}
		if (other.tag == "finishline") {
			SceneManager.LoadScene ("End");
		}
	}
}
