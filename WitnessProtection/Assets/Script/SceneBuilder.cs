using UnityEngine;
using System.Collections;

public class SceneBuilder : MonoBehaviour {
	public GameObject theApple;
	public GameObject theAxe;
	public GUIText clueText;
	public GUITexture clueBox;

	// Use this for initialization
	void Start () {
		makeSceneForWitness(0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void makeSceneForWitness(int whom){
		//just one setup at the moment

	//	theApple.rect.center = new Vector3(-.7f,.6f,-1);
		theApple.transform.localPosition = new Vector3(-.7f,.6f,-1);
		theAxe.transform.localPosition = new Vector3(2.0f,-.4f,-1);

		clueText.text = "";
		clueBox.enabled = false;

		writeClue ();
	}

	void writeClue(){
		clueBox.enabled = true;
		clueBox.transform.position = new Vector3(.4f, .4f, -2);
		clueText.text = "Man, what's up with apples";
	}
}
