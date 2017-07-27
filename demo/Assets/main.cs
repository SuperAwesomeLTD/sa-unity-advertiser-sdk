using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using tv.superawesome.sdk.advertiser;

public class main : MonoBehaviour {

	// Use this for initialization
	void Start () {

		SAVerifyInstall.getInstance ().handleInstall ((success) => {
			Debug.Log ("Handled install " + success);
		});

	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
