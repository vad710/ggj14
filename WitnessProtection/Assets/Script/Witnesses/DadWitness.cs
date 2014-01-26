using UnityEngine;
using System.Collections;

namespace Assets.Script.Witnesses
{
	public class DadWitness : IWitness
	{
	// Use this for initialization
	void Start () {
		this.SawGun = true;
		this.GunPosition = new Vector2(4.6f,-3.3f);
		this.GunSize = new Vector2(.6f,.6f);
		this.GunCommentary = "I can't believe she stole my gun";
		
		this.SawPurse = false;
		this.PursePosition = new Vector2(-1.1f,1.12f);
		this.PurseSize = new Vector2(.6f,.6f);
		this.PurseCommentary = "";
		
		this.SawToy = false;
		this.ToyPosition = new Vector2(-4.9f,-.9f);
		this.ToySize = new Vector2(.6f,.6f);
		this.ToyCommentary = "";
		
		this.SawHole = true;
		this.HolePosition = new Vector2(-2,4);
		this.HoleSize = new Vector2(.7f,.7f);
		this.HoleCommentary = "That's where I shoved the hobo's face";

		this.SawJacket = true;
		this.JacketPosition = new Vector2(2,-2);
		this.JacketSize = new Vector2(.7f,.7f);
		this.JacketCommentary = "That's the jacket I got Olivia for her birthday";

	}

	public bool SawGun { get; private set; }
	public Vector2 GunPosition { get; private set; }
	public Vector2 GunSize { get; private set; }
	public string GunCommentary { get; private set; }
	
	public bool SawPurse { get; private set; }
	public Vector2 PursePosition { get; private set; }
	public Vector2 PurseSize { get; private set; }
	public string PurseCommentary { get; private set; }
	
	public bool SawToy { get; private set; }
	public Vector2 ToyPosition { get; private set; }
	public Vector2 ToySize { get; private set; }
	public string ToyCommentary { get; private set; }
	
	public bool SawHole { get; private set; }
	public Vector2 HolePosition { get; private set; }
	public Vector2 HoleSize { get; private set; }
	public string HoleCommentary { get; private set; }
	
	public bool SawJacket { get; private set; }
	public Vector2 JacketPosition { get; private set; }
	public Vector2 JacketSize { get; private set; }
	public string JacketCommentary { get; private set; }

	}
}
