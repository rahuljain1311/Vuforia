using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using Vuforia;

public class WalkScript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject button;
	private GameObject zombie;
	// Use this for initialization
	void Start () {

		button = GameObject.Find ("VirtualButton");
		button.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
		zombie = GameObject.Find ("zombie");
	}

	public void OnButtonPressed(VirtualButtonAbstractBehaviour vb){

//		Debug.Log ("Button pressed virtual");
		zombie.GetComponent<Animation>().Play ();
	}

	public void OnButtonReleased(VirtualButtonAbstractBehaviour vb){

		zombie.GetComponent<Animation>().Stop();
//		Debug.Log ("Button released virtual");
	}
}
