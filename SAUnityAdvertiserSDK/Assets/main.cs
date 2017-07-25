using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SuperAwesome;

public class main : MonoBehaviour {

	// Use this for initialization
	void Start () {

		SuperAwesomeAdvertiser.getInstance ().handleInstall ((success) => {
			Debug.Log ("Handled install " + success);
		});

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
