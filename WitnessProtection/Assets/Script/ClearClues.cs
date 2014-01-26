using UnityEngine;
using System.Collections;

public class ClearClues : MonoBehaviour {

	public GUIText clueText;
	public GUITexture clueBox;

	void OnMouseDown()
	{
		clueBox.enabled = false;
		clueText.text = "";
	}
}
