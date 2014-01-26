using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class HomelessWitness : IWitness
    {
		public HomelessWitness()
        {
			this.SawGun = false;
			this.GunPosition = new Vector2(4.6f,-3.3f);
			this.GunSize = new Vector2(.6f,.6f);
			this.GunCommentary = "";
			
			this.SawPurse = true;
			this.PursePosition = new Vector2(-5.92f, -.25f);
			this.PurseSize = new Vector2(1,1);
			this.PurseCommentary = "That's what I came in here looking for.";
			
			this.SawToy = false;
			this.ToyPosition = new Vector2(-4.9f,-.9f);
			this.ToySize = new Vector2(.6f,.6f);
			this.ToyCommentary = "";
			
			this.SawHole = true;
			this.HolePosition = new Vector2(-2,4);
			this.HoleSize = new Vector2(.7f,.7f);
			this.HoleCommentary = "I was just lookin' for some cash... and that man tore in here like a barrel of whips!";
			
			this.SawJacket = true;
			this.JacketPosition = new Vector2(2,-2);
			this.JacketSize = new Vector2(.7f,.7f);
			this.JacketCommentary = "Boy, I could really use a nice jacket like that on these very cold nights.";
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
