using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class BlindWitness : IWitness
    {
		public BlindWitness()
        {
			this.WhoAmI = WitnessNames.EthanName;

			this.SawGun = true;
			this.GunPosition = new Vector2(-.26f, -2.3f);
			this.GunSize = new Vector2(1,1);
			this.GunCommentary = "I heard a shot prior to hearing a lot of scuffling";
			
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
			this.HoleCommentary = "There was a fight!  I heard it!";

			this.SawJacket = false;
			this.JacketPosition = new Vector2(-5.12f,-3.75f);
			this.JacketSize = new Vector2(1,1);
			this.JacketCommentary = "";
			
			this.LeftFolderText = "\"I was fully blind by the age 15. I hated god, everyone, and the world for making it so. You know how your other senses are supposed to become stronger to compensate? Well lemme tell you, my sense of taste is out of this world. I get by, in fact, I do better than most! I’m quite the connoisseur with these tastebuds of mine. Heading out to Italy next week, my cousin’s got a vineyard..can you say party?? My hearing is great too but what I heard.. That woman’s scream will haunt me for years to come..";
			this.RightFolderText = "You say it was the kid who was shot? Well I heard the shot alright, loud and clear, but there was no commotion prior. But I guess things do go “bump” (or “bang!” heh) in the night.. Lot of commotion going on, a fight between two men i’m guessing. What the hell is this all about anyway? I feel an ill omen.\"";
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
        public string RightFolderText { get; set; }
    }
}
