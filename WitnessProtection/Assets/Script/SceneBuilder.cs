using Assets.Script;
using Assets.Script.Witnesses;
using UnityEngine;
using System.Collections;

public class SceneBuilder : MonoBehaviour {
	public Clue theGun;
	public Clue thePurse;
	public Clue theToy;
	public Clue theHole;
	public Clue theJacket;

	public GUIText clueText;
	public GUITexture clueBox;
	public Camera theCamera;
	public GameObject normalBackground;
	public GameObject blindBackground;

	// Use this for initialization
	public void Start () 
    {
		makeSceneForWitness(0);

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
	}

	void makeSceneForWitness(int whom){
		//just one setup at the moment

	//	theApple.transform.localPosition = new Vector3(-.7f,.6f,-1);
	//	theAxe.transform.localPosition = new Vector3(2.0f,-.4f,-1);

		clueText.text = "";
		clueBox.enabled = false;

	//	writeClue ();
	}

	public void writeClue(string theText, Vector3 thePosition)
    {
		clueBox.enabled = true;

		var screenPosition = theCamera.WorldToScreenPoint(thePosition);
		var guiPosition = new Vector2(screenPosition.x / Screen.width, screenPosition.y / Screen.height);
		clueBox.transform.position = GUIUtility.ScreenToGUIPoint(guiPosition);

		clueBox.transform.position = new Vector3(clueBox.transform.position.x,clueBox.transform.position.y,-2);
		clueText.text = theText;
	}
	
}
