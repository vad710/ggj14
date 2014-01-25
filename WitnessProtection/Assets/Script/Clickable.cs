using UnityEngine;
using System.Collections;

public class Clickable : MonoBehaviour {
	public string onMouseDown;
	public string onMouseOver;
	public string onMouseExit;
	
	void OnMouseOver(){
		if(onMouseOver == null){return;}
	}
	
	void OnMouseExit(){
		if(onMouseExit == null){return;}
	}
	
	void OnMouseDown(){
		if(onMouseDown == null){return;}
	}

}
