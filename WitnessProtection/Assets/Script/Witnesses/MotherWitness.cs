using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class MotherWitness : IWitness
    {
		public MotherWitness()
        {
			this.SawGun = true;
			this.GunPosition = new Vector2(5.8f,1.7f);
			this.GunSize = new Vector2(.6f,.6f);
			this.GunCommentary = "I took the gun to defend myself against Caleb";
			
			this.SawPurse = true;
			this.PursePosition = new Vector2(-2.2f,3.9f);
			this.PurseSize = new Vector2(.7f,.7f);
			this.PurseCommentary = "That's not where I left my purse...";

			this.SawToy = true;
			this.ToyPosition = new Vector2(0,0);
			this.ToySize = new Vector2(0,0);
			this.ToyCommentary = "I do not remember that toy...";
			
			this.SawHole = true;
			this.HolePosition = new Vector2(0,0);
			this.HoleSize = new Vector2(0,0);
			this.HoleCommentary = "What happened here?";

			////

			this.SawJacket = false;
			this.JacketPosition = new Vector2(0,0);
			this.JacketSize = new Vector2(0,0);
			this.JacketCommentary = "";

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
