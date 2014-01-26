using UnityEngine;

namespace Assets.Script
{

public class FolderBuilder : MonoBehaviour {

	public GameObject openFolder;
	public GameObject closedFolder;

	// Use this for initialization
	public void Start () {

        GameState.Instance().SetupResolution();

		if(GameState.Instance().previousSceneString == "NewsScene" || string.IsNullOrEmpty(GameState.Instance().previousSceneString ))
        {
			showClosed ();
		}
		else
        {
			showOpen ();
		}
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
