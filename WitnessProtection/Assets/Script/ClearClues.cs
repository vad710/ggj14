using UnityEngine;
using System.Collections;

public class ClearClues : MonoBehaviour {

	public GameObject clueBox;

	void OnMouseDown()
	{
		clueBox.SetActive(false);
	}
}
