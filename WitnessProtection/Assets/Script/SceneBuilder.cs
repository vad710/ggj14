using Assets.Script;
using Assets.Script.Witnesses;
using UnityEngine;
using System.Collections;

namespace Assets.Script
{

public class SceneBuilder : MonoBehaviour {
	public Clue theGun;
	public Clue thePurse;
	public Clue theToy;
	public Clue theHole;
	public Clue theJacket;
//	public Clue clearClue;

	public SpriteRenderer upperCornerPhoto;

	public Sprite ethanSprite;
	public Sprite eliSprite;
	public Sprite oliviaSprite;
	public Sprite calebSprite;
	public Sprite dannySprite;
	public Sprite martaSprite;

//	public GUIText clueText;
//	public GUITexture clueBox;
//	public GUITexture clueFace;

	public GameObject cluePopUp;
	public SpriteRenderer clueFace;
	public TextMesh clueText;

	public TextMesh achievementText;
	public SpriteRenderer achievementFace;
	public GameObject achievementBox;

	public Camera theCamera;
	public GameObject normalBackground;
	public GameObject blindBackground;

	int tick;

	// Use this for initialization
	public void Start () 
    {
		tick = 0;

		makeSceneForWitness(0);
		achievementBox.SetActive(false);

	    if (GameState.Instance().WitnessToInvestigate == null)
	    {
            //this is only for debugging - when the user gets here normally, the "WitnessToInvestigate" should already be set to an object
 
	        GameState.Instance().WitnessToInvestigate = new HouseKeeperWitness();
	    }

		this.MakeSceneForWitness(GameState.Instance().WitnessToInvestigate);
	}

    private void MakeSceneForWitness(IWitness witness)
    {
		theGun.setObjectProperties(witness.GunCommentary, witness.GunPosition, witness.GunSize, witness.SawGun, this);
		thePurse.setObjectProperties(witness.PurseCommentary, witness.PursePosition, witness.PurseSize, witness.SawPurse, this);
		theToy.setObjectProperties(witness.ToyCommentary, witness.ToyPosition, witness.ToySize, witness.SawToy, this);
		theHole.setObjectProperties(witness.HoleCommentary, witness.HolePosition, witness.HoleSize, witness.SawHole, this);
		theJacket.setObjectProperties(witness.JacketCommentary, witness.JacketPosition, witness.JacketSize, witness.SawJacket, this);
	//	clearClue.setObjectProperties("", new Vector3(-20,-20,5), new Vector3(0,0,0), false, this);

		if(witness.WhoAmI == "Ethan"){
			blindBackground.SetActive(true);
			upperCornerPhoto.sprite = ethanSprite;
		}
		else if(witness.WhoAmI == "Eli"){
			blindBackground.SetActive(false);
			upperCornerPhoto.sprite = eliSprite;
		}
		else if(witness.WhoAmI == "Olivia"){
			blindBackground.SetActive(false);
			upperCornerPhoto.sprite = oliviaSprite;
		}
		else if(witness.WhoAmI == "Marta"){
			blindBackground.SetActive(false);
			upperCornerPhoto.sprite = martaSprite;
		}
		else if(witness.WhoAmI == "Danny"){
			blindBackground.SetActive(false);
			upperCornerPhoto.sprite = dannySprite;
		}
		else if(witness.WhoAmI == "Caleb"){
			blindBackground.SetActive(false);
			upperCornerPhoto.sprite = calebSprite;
		}

	//	writeAchievement("New Witness! The duuuude");
	}

	void makeSceneForWitness(int whom){
		//just one setup at the moment

	//	theApple.transform.localPosition = new Vector3(-.7f,.6f,-1);
	//	theAxe.transform.localPosition = new Vector3(2.0f,-.4f,-1);

		clueText.text = "";
		cluePopUp.SetActive(false);

	//	writeClue ();
	}

	public void writeClue(string theText, Vector3 thePosition)
    {
		cluePopUp.SetActive(true);
	//	clueBox.enabled = true;
	//	clueFace.enabled = true;

	//	var screenPosition = theCamera.WorldToScreenPoint(thePosition);
	//	var guiPosition = new Vector2(screenPosition.x / Screen.width, screenPosition.y / Screen.height);
	//	clueBox.transform.position = GUIUtility.ScreenToGUIPoint(guiPosition);

	//	clueBox.transform.position = new Vector3(clueBox.transform.position.x,clueBox.transform.position.y,-2);
		cluePopUp.transform.position = thePosition;

		clueText.text = theText;
		clueText.GetComponent<TextWrapper>().Wrap();

	//	upperCornerPhoto.sprite = dannySprite;
		clueFace.sprite = upperCornerPhoto.sprite;
		checkForAchievements(theText);
	}

	void checkForAchievements(string theText){
		if(theText == "I took the gun to defend myself against Caleb"){
			if(!GameState.Instance().CalebUnlocked){
				writeAchievement("New Witness: Caleb\nRelation: Father");
				GameState.Instance().CalebUnlocked = true;
				achievementFace.sprite = calebSprite;
			}
		}
		if(theText == "What is my son's toy doing here?"){
			if(!GameState.Instance().DannyUnlocked){
				Debug.Log("son's toy");
				writeAchievement("New Witness: Danny\nRelation: Maid's Kid");
				GameState.Instance().DannyUnlocked = true;
				achievementFace.sprite = dannySprite;
			}
		}
		if(theText == "That's where I shoved that hobo/thief’s face in."){
			if(!GameState.Instance().EliUnlocked){
				writeAchievement("New Witness: Eli\nRelation: Hobo");
				GameState.Instance().EliUnlocked = true;
				achievementFace.sprite = eliSprite;
			}
		}
	}

	public void writeAchievement(string theText)
	{
		achievementBox.SetActive(true);

		achievementText.text = theText;
	//		achievementText.GetComponent<TextWrapper>().Wrap ();

		tick = 0;
	}

	void Update(){
		if(achievementBox.activeSelf){
			tick += 1;
			if(tick < 60){
				//achievementBox.color.a = 1;
			}
			else if(tick < 290){
			//	achievementBox.color = new Color(1,1,1,(90.0f-tick)/30.0f);
			//	achievementText.color = new Color(0,0,0,(90.0f-tick)/30.0f);
			}
			else{
				achievementBox.SetActive(false);
			}

		}

	}
}
}
