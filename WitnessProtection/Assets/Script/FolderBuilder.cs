using UnityEngine;
using System.Collections;

namespace Assets.Script
{

public class FolderBuilder : MonoBehaviour {

	public GameObject openFolder;
	public GameObject closedFolder;

	// Use this for initialization
	void Start () {

		if(GameState.Instance().previousSceneString == "NewsScene"){
			showClosed ();
		}
		else{
			showOpen ();
		}
	//	showClosed ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void showOpen(){
		openFolder.SetActive(true);
		closedFolder.SetActive(false);
	}

	void showClosed(){
		openFolder.SetActive(false);
		closedFolder.SetActive(true);
	}

}
}
