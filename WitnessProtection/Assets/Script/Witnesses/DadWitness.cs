﻿using UnityEngine;
using System.Collections;

namespace Assets.Script.Witnesses
{
	public class DadWitness : IWitness
	{
	// Use this for initialization
	public DadWitness () {
			this.WhoAmI = "DadWitness";

			
			this.SawGun = true;
			this.GunPosition = new Vector2(-.26f, -2.3f);
			this.GunSize = new Vector2(1,1);
			this.GunCommentary = "I can't believe she stole my gun";
		
		this.SawPurse = false;
			this.PursePosition = new Vector2(-5.92f, -.25f);
			this.PurseSize = new Vector2(1,1);
			this.PurseCommentary = "";
		
		this.SawToy = false;
			this.ToyPosition = new Vector2(4.57f,-4.0f);
			this.ToySize = new Vector2(1,1);
			this.ToyCommentary = "";
		
		this.SawHole = true;
			this.HolePosition = new Vector2(-1.76f,3.37f);
			this.HoleSize = new Vector2(1,1);
			this.HoleCommentary = "That's where I shoved the hobo's face";

		this.SawJacket = true;
			this.JacketPosition = new Vector2(-5.12f,-3.75f);
			this.JacketSize = new Vector2(1,1);
			this.JacketCommentary = "That's the jacket I got Olivia for her birthday";

	}

		public string WhoAmI { get; private set; }

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
	    public string LeftFolderText { get; set; }
	}
}
