using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class HomelessWitness : IWitness
    {
		public HomelessWitness()
		{
		    this.WhoAmI = WitnessNames.EliName;

			this.SawGun = false;
			this.GunPosition = new Vector2(-.26f, -2.3f);
			this.GunSize = new Vector2(1,1);
			this.GunCommentary = "";
			
			this.SawPurse = true;
			this.PursePosition = new Vector2(-5.92f, -.25f);
			this.PurseSize = new Vector2(1,1);
			this.PurseCommentary = "That's what I came in looking for. Either that or some booze *hiccup*";
			
			this.SawToy = false;
			this.ToyPosition = new Vector2(4.57f,-4.0f);
			this.ToySize = new Vector2(1,1);
			this.ToyCommentary = "";
			
			this.SawHole = true;
			this.HolePosition = new Vector2(-1.76f,3.37f);
			this.HoleSize = new Vector2(1,1);
			this.HoleCommentary = "This guy flies in like a bat outta hell and attacks me.";
			
			this.SawJacket = true;
			this.JacketPosition = new Vector2(-5.12f,-3.75f);
			this.JacketSize = new Vector2(1,1);
			this.JacketCommentary = "Boy, I could really use a nice jacket like that on these cold days.";

			this.LeftFolderText = "\"Now if you got me under “oath” detective, I’ll admit i usually go through the open rooms lookin’ for some shtuff *hiccup*. Sometimes I get lucky: a purse here, a wallet there. You’d be surprised how often people leave their doors open! *hiccup*. Idiots. Anyway, somethin’ woke me up and I needed a drink. I see this chick leaving 14b so I went for a look see. Unlocked. Am I good or am I good?";
			this.RightFolderText = "She had some nice stuff man, but someone knew I was in there and scared the $h!t outta me, *hiccup* busted in and came after me! He and I tussled for a few, but he didn’t know who he was dealing with heh *hiccup*. I was out the back like a thief in the night, *hiccup*. This blood on me ain’t no child’s so you can’t pin nothin’ on me detective.\"";
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
