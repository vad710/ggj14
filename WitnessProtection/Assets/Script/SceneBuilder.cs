﻿using Assets.Script;
using UnityEngine;
using System.Collections;

public class SceneBuilder : MonoBehaviour {
	public Clue theApple;
	public Clue theAxe;
	public Clue blindClue1;
	public Clue blindClue2;

	public GUIText clueText;
	public GUITexture clueBox;
	public Camera theCamera;
	public GameObject normalBackground;
	public GameObject blindBackground;

	// Use this for initialization
	public void Start () 
    {
		makeSceneForWitness(0);

	//	theApple.setObjectProperties("Wow, an apple", new Vector3(-.6f,-.5f,-1), this);
	//	theAxe.setObjectProperties("Wow, an axe", new Vector3(3,-.4f,-1), this);

		GameState.Instance().SwitchToHouseKeeper();
		this.MakeSceneForWitness(GameState.Instance().WitnessToInvestigate);
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey("right")){
			GameState.Instance().SwitchToHouseKeeper();
			this.MakeSceneForWitness(GameState.Instance().WitnessToInvestigate);
			blindBackground.SetActive(false);
			normalBackground.SetActive(true);
		}
		if(Input.GetKey("left")){
			GameState.Instance().SwitchToBlind();
			this.MakeSceneForWitness(GameState.Instance().WitnessToInvestigate);
			blindBackground.SetActive(true);
			normalBackground.SetActive(false);
		}
		if(Input.GetKey("up")){
			GameState.Instance().SwitchToHomeless();
			this.MakeSceneForWitness(GameState.Instance().WitnessToInvestigate);
			blindBackground.SetActive(false);
			normalBackground.SetActive(true);
		}
		if(Input.GetKey("down")){
			GameState.Instance().SwitchToMother();
			this.MakeSceneForWitness(GameState.Instance().WitnessToInvestigate);
			blindBackground.SetActive(false);
			normalBackground.SetActive(true);
		}

	}

    private void MakeSceneForWitness(IWitness witness)
    {
		theApple.setObjectProperties(witness.AppleCommentary, witness.ApplePosition, witness.AppleSize, witness.SawApple, this);
		theAxe.setObjectProperties(witness.AxeCommentary, witness.AxePosition, witness.AxeSize, witness.SawAxe, this);
		blindClue1.setObjectProperties(witness.Blind1Commentary, witness.Blind1Position, witness.Blind1Size, witness.SawBlind1, this);
		blindClue2.setObjectProperties(witness.Blind2Commentary, witness.Blind2Position, witness.Blind2Size, witness.SawBlind2, this);
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
