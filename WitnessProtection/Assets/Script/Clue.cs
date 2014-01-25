using UnityEngine;
using System.Collections;

public class Clue : MonoBehaviour {

	string clueText;
	Vector3 cluePosition;
	Vector3 textPosition;
	SceneBuilder theSceneBuilder;

	// Use this for initialization
	void Start () {
	//	clueText = "Unset";
	//	cluePosition = new Vector3(0,0,0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setObjectProperties(string theClue, Vector3 thePosition, SceneBuilder theBuilder){
		theSceneBuilder = theBuilder;
		clueText = theClue;
		cluePosition = thePosition;

		enabled = true;

		this.gameObject.transform.position = cluePosition;
	//	Vector3 intermediatePos = Camera.WorldToScreenPoint(cluePosition);
		textPosition = new Vector3(cluePosition.x, cluePosition.y - 1.8f, -2);
	}

	public void disableIt(){
		enabled = false;
	}

	void OnMouseOver(){
		if(this.transform.localScale.x == .4f){return;}
		renderer.material.color = new Color(1, 1, 1,.6f);
	}

	void OnMouseExit(){
		this.transform.localScale = new Vector3(.3f,.3f,1);
		renderer.material.color = new Color(1, 1, 1,1);
	}

	void OnMouseDown(){
		this.transform.localScale = new Vector3(.4f,.4f,1);
		renderer.material.color = new Color(1, 1, 1,1);
		Debug.Log(clueText);
		theSceneBuilder.writeClue(clueText, textPosition);
	}
}
