using UnityEngine;

namespace Assets.Script.Witnesses
{
    public class MotherWitness : IWitness
    {
		public MotherWitness()
        {
			this.SawApple = true;
			this.ApplePosition = new Vector2(5.8f,1.7f);
			this.AppleSize = new Vector2(.6f,.6f);
			this.AppleCommentary = "The apple looked like I was a mother.";
			
			this.SawAxe = true;
			this.AxePosition = new Vector2(-2.2f,3.9f);
			this.AxeSize = new Vector2(.7f,.7f);
			this.AxeCommentary = "The axe looked like I was a mother.";

			this.SawBlind1 = false;
			this.Blind1Position = new Vector2(0,0);
			this.Blind1Size = new Vector2(0,0);
			this.Blind1Commentary = "";
			
			this.SawBlind2 = false;
			this.Blind2Position = new Vector2(0,0);
			this.Blind2Size = new Vector2(0,0);
			this.Blind2Commentary = "";

		}

		public bool SawApple { get; private set; }
		public Vector2 ApplePosition { get; private set; }
		public Vector2 AppleSize { get; private set; }
		public string AppleCommentary { get; private set; }
		
		public bool SawAxe { get; private set; }
		public Vector2 AxePosition { get; private set; }
		public Vector2 AxeSize { get; private set; }
		public string AxeCommentary { get; private set; }

		public bool SawBlind1 { get; private set; }
		public Vector2 Blind1Position { get; private set; }
		public Vector2 Blind1Size { get; private set; }
		public string Blind1Commentary { get; private set; }
		
		public bool SawBlind2 { get; private set; }
		public Vector2 Blind2Position { get; private set; }
		public Vector2 Blind2Size { get; private set; }
		public string Blind2Commentary { get; private set; }

	}
}
