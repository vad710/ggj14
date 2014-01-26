using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class MotherWitness : IWitness
    {
		public MotherWitness()
        {
			this.WhoAmI = WitnessNames.OliviaName;

			this.SawGun = true;
			this.GunPosition = new Vector2(-.26f, -2.3f);
			this.GunSize = new Vector2(1,1);
			this.GunCommentary = "I took the gun to defend myself against Caleb";
			
			this.SawPurse = true;
			this.PursePosition = new Vector2(-5.92f, -.25f);
			this.PurseSize = new Vector2(1,1);
			this.PurseCommentary = "That's not where I left my purse...";

			this.SawToy = true;
			this.ToyPosition = new Vector2(4.57f,-4.0f);
			this.ToySize = new Vector2(1,1);
			this.ToyCommentary = "I do not remember that toy...";
			
			this.SawHole = true;
			this.HolePosition = new Vector2(-1.76f,3.37f);
			this.HoleSize = new Vector2(1,1);
			this.HoleCommentary = "What happened here?";

			////

			this.SawJacket = false;
			this.JacketPosition = new Vector2(-5.12f,-3.75f);
			this.JacketSize = new Vector2(1,1);
			this.JacketCommentary = "";


            this.LeftFolderText = "My life has been horrible and now it’s all over. My only child, my only son. You’ll never be able to understand detective. All I wanted to do is get away from my husband and have a chance at a normal life. That man has ruined everything in me. Even before Benny was killed I began to see my husband in him.. it’s a like some bad dream, a horror tale, except it’s true. Does justice even matter at this point? If you want to do me justice, kill that man. Kill my husband! He doesn’t deserve to live, look what he’s done to my face, look what he’s done to my life. He is the devil and all that comes for him or touches him is evil to me.";
            this.RightFolderText = "I don’t how that demon found me, but he did. I left the room, and when I come back my son is dead, and that man was there.";
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
