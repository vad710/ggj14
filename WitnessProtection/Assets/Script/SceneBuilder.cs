using Assets.Script;
using UnityEngine;
using System.Collections;

public class SceneBuilder : MonoBehaviour {
	public Clue theApple;
	public Clue theAxe;
	public GUIText clueText;
	public GUITexture clueBox;
	public Camera theCamera;

	// Use this for initialization
	public void Start () 
    {
		makeSceneForWitness(0);

		theApple.setObjectProperties("Wow, an apple", new Vector3(-.6f,-.5f,-1), this);
		theAxe.setObjectProperties("Wow, an axe", new Vector3(3,-.4f,-1), this);

		GameState.Instance().SwitchToHouseKeeper();

		this.MakeSceneForWitness(GameState.Instance().WitnessToInvestigate);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    private void MakeSceneForWitness(IWitness witness)
    {
		if(witness.SawApple){
			theApple.setObjectProperties(witness.AppleCommentary, witness.ApplePosition, this);
		}
		else{
			theApple.disableIt();
		}
	//	theAxe.setObjectProperties(witness., this);

    }

	void makeSceneForWitness(int whom){
		//just one setup at the moment

	//	theApple.transform.localPosition = new Vector3(-.7f,.6f,-1);
	//	theAxe.transform.localPosition = new Vector3(2.0f,-.4f,-1);

		clueText.text = "";
		clueBox.enabled = false;

	//	writeClue ();
	}

	public void writeClue(string theText, Vector3 thePosition){
		clueBox.enabled = true;

		Vector2 screenPosition = theCamera.WorldToScreenPoint(thePosition);
		Vector2 guiPosition = new Vector2(screenPosition.x / Screen.width, screenPosition.y / Screen.height);
		clueBox.transform.position = GUIUtility.ScreenToGUIPoint(guiPosition);

		clueBox.transform.position = new Vector3(clueBox.transform.position.x,clueBox.transform.position.y,-2);
		clueText.text = theText;
	}
	
}
