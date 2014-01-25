using UnityEngine;
using System.Collections;

public class DeskTransition : MonoBehaviour {
	public GameObject deskScene;
	public GameObject motelScene;

	bool showingDesk;

	// Use this for initialization
	void Start () {
		showingDesk = false;

		goToDesk ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void goToMotel(){
		if(!showingDesk){return;}
		showingDesk = false;

		deskScene.SetActive(false);// = false;
		motelScene.SetActive(true);// = false;
	}

	void goToDesk(){
		if(showingDesk){return;}
		showingDesk = true;

		deskScene.SetActive(true);// = false;
		motelScene.SetActive(false);// = false;
	}

}
