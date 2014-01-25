using UnityEngine;
using System.Collections;

public class Clue : MonoBehaviour {

	string clueText;
	Vector3 cluePosition;
	Vector3 clueSize;
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

	public void setObjectProperties(string theClue, Vector3 thePosition, Vector3 theSize, bool shown, SceneBuilder theBuilder){
		theSceneBuilder = theBuilder;
		clueText = theClue;
		cluePosition = thePosition;
		clueSize = theSize;
		enabled = shown;

		this.gameObject.transform.localPosition = cluePosition;
		this.gameObject.transform.localScale = clueSize;
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
		this.transform.localScale = clueSize;
		renderer.material.color = new Color(1, 1, 1,1);
	}

	void OnMouseDown(){
		this.transform.localScale = new Vector3(clueSize.x+.05f,clueSize.y+.05f,1);
		renderer.material.color = new Color(1, 1, 1,1);
		Debug.Log(clueText);
		theSceneBuilder.writeClue(clueText, textPosition);
	}
}
