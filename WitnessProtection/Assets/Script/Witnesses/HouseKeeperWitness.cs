using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class HouseKeeperWitness : IWitness
    {
        public HouseKeeperWitness()
        {
            this.WhoAmI = WitnessNames.MartaName;

			this.SawGun = false;
			this.GunPosition = new Vector2(-.26f, -2.3f);
			this.GunSize = new Vector2(1,1);
			this.GunCommentary = "";
			
			this.SawPurse = false;
			this.PursePosition = new Vector2(-5.92f, -.25f);
			this.PurseSize = new Vector2(1,1);
			this.PurseCommentary = "";
			
			this.SawToy = true;
			this.ToyPosition = new Vector2(4.57f,-4.0f);
			this.ToySize = new Vector2(1,1);
			this.ToyCommentary = "What is my son's toy doing here?";
			
			this.SawHole = true;
			this.HolePosition = new Vector2(-1.76f,3.37f);
			this.HoleSize = new Vector2(1,1);
			this.HoleCommentary = "What happened here?";
			
			this.SawJacket = false;
			this.JacketPosition = new Vector2(-5.12f,-3.75f);
			this.JacketSize = new Vector2(1,1);
			this.JacketCommentary = "";

			this.LeftFolderText = "Ai, Dios mío!I don’t know anyting! Don’t accuse me! I’ve worked at dis motel for seben years, my family lives here and we make honest living in the U.S. I have noting to lose, and everyting to gain! One day my familia will move from here. One day we’ll live in a house, my kids will go to college -- my boy! He met the little nino, the one who was murdered—Oh! and I’ll have a garden! Until then I take it one day at a time. Cleaning these rooms. This motel.. it’s haunted, dectective. It’s the trus! Bad tings continue to happen.";
			this.RightFolderText = "You have a murder on your hands? Well I’m not surprised. 'El Diablo a la dentro.' I feel condemned here at times, that the forces of nature, the economy, or perhaps something more is keeping me and my people back. I come in, I see the body, I clean up the mess, I have nothing else to say.";
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
