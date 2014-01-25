using UnityEngine;
using System.Collections;

public class HoverClue : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
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
	}
}
