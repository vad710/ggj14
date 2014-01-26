using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class BlindWitness : IWitness
    {
		public BlindWitness()
        {
			this.SawGun = true;
			this.GunPosition = new Vector2(5.8f,1.7f);
			this.GunSize = new Vector2(.6f,.6f);
			this.GunCommentary = "I heard a shot prior to hearing a lot of scuffling";
			
			this.SawPurse = false;
			this.PursePosition = new Vector2(-2.2f,3.9f);
			this.PurseSize = new Vector2(.7f,.7f);
			this.PurseCommentary = "";
			
			this.SawToy = false;
			this.ToyPosition = new Vector2(0,0);
			this.ToySize = new Vector2(0,0);
			this.ToyCommentary = "";
			
			this.SawHole = true;
			this.HolePosition = new Vector2(0,0);
			this.HoleSize = new Vector2(0,0);
			this.HoleCommentary = "There was a fight!  I heard it!";

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
