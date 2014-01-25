using UnityEngine;
using System.Collections;

public class OpenFolder : MonoBehaviour {

	public GameObject closedFolder;
	public GameObject openFolder;


	public void OnMouseDown(){
		Debug.Log("what what ahwat");
		closedFolder.SetActive(false);
		openFolder.SetActive(true);
	}
}
