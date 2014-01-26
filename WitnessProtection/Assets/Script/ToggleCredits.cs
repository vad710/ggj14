using UnityEngine;
using System.Collections;

public class ToggleCredits : MonoBehaviour {
	public GameObject theCredits;


	void OnMouseDown(){
		theCredits.SetActive (!theCredits.activeSelf);
	}
}
